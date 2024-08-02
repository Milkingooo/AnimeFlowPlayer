using AnimeFlowPlayer.Model;
using AnimeFlowPlayer.ViewModel;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;

namespace AnimeFlowPlayer.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для CatalogWindow.xaml
    /// </summary>
    public partial class CatalogWindow : Window
    {
        public CatalogWindow()
        {
            InitializeComponent();
            DataContext = new CatalogWindowViewModel();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string filePath = "Catalog.dat";

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл {filePath} не найден.");
                return;
            }

            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    // считываем из файла строку
                    string catalog = reader.ReadString();
                    Console.WriteLine($"Catalog: {catalog}");


                    (DataContext as CatalogWindowViewModel)?.FillCatalog(catalog);
                    CatalogList.ItemsSource = (DataContext as CatalogWindowViewModel).films;
                    Console.WriteLine("File has been deserialized");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Каталог не загружен: {ex.Message}");
            }
        }

        private void offlineButton_Click(object sender, RoutedEventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Выберите папку";

                if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SelectedDirectorySingleton.directory = folderBrowserDialog.SelectedPath;
                    (DataContext as CatalogWindowViewModel)?.FillCatalog(SelectedDirectorySingleton.directory);
                    CatalogList.ItemsSource = (DataContext as CatalogWindowViewModel).films;
                    Console.WriteLine($"Catalog has selectes: {folderBrowserDialog.SelectedPath}");
                }
            }

            if (!string.IsNullOrWhiteSpace(SelectedDirectorySingleton.directory))
            {
                try
                {
                    using (BinaryWriter writer = new BinaryWriter(File.Open("Catalog.dat", FileMode.OpenOrCreate)))
                    {
                        // записываем в файл строку
                        writer.Write(SelectedDirectorySingleton.directory);
                        Console.WriteLine("File has been serialized");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка при записи файла: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Путь к каталогу не установлен или пустой.");
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var border = sender as Border;
            if (border != null)
            {
                // Получаем контекст данных для элемента
                var videoItem = border.DataContext as Film; // Предположим, что у вас есть класс VideoItem
                if (videoItem != null)
                {
                    // Передаем название в SelectedVideoSingleton
                    SelectedVideoSingleton.video = videoItem.Title; // Пример передачи
                }
            }

            MediaWindow detailWindow = new MediaWindow();
            detailWindow.Show();
            Close();
        }
    }


}
