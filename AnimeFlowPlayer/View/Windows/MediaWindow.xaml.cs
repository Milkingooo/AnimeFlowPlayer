using AnimeFlowPlayer.Model;
using AnimeFlowPlayer.ViewModel;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AnimeFlowPlayer.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MediaWindow.xaml
    /// </summary>
    public partial class MediaWindow : Window
    {
        DispatcherTimer timer;
        string catalog;

        public MediaWindow()
        {
            InitializeComponent();
            DataContext = new MediaWindowViewModel();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += timer_tick;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            CatalogWindow catalogWindow = new CatalogWindow();
            catalogWindow.Show();
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string filePath = "Catalog.dat";

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                // считываем из файла строку
                catalog = reader.ReadString();
                Console.WriteLine($"Catalog: {catalog}");

                (DataContext as MediaWindowViewModel)?.FillCatalog(catalog + "/" + SelectedVideoSingleton.video);
                seriesCatalog.ItemsSource = (DataContext as MediaWindowViewModel).series;
                Console.WriteLine("File has been deserialized");
                Console.WriteLine($"Series has downloaded!");
            }

            mediaElement.Play();
            timer.Start();
        }
        private void timer_tick(object sender, EventArgs e)
        {
            if (mediaElement.NaturalDuration.HasTimeSpan)
            {
                time.Text = mediaElement.Position.ToString(@"mm\:ss");
                slider2.Maximum = mediaElement.NaturalDuration.TimeSpan.TotalSeconds;
                slider2.Value = mediaElement.Position.TotalSeconds;
            }
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Play();  //  Start playing
            timer.Start();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Pause(); //  Pause the current play
            timer.Stop();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop(); //  Stop current play
            slider2.Value = 0;
            timer.Stop();
        }

        private void seriesCatalog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mediaElement.Source = new Uri(catalog + @"\" + SelectedVideoSingleton.video + @"\" + seriesCatalog.SelectedItem.ToString());
        }

        private void mediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            slider2.Maximum = mediaElement.NaturalDuration.TimeSpan.TotalSeconds;
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (mediaElement != null)
            {
                mediaElement.Volume = slider1.Value;
            }
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            if (mediaElement.NaturalDuration.HasTimeSpan)
            {
                mediaElement.Position = TimeSpan.FromSeconds(slider2.Value);
            }
        }

        private void fullscreenButton_Click(object sender, RoutedEventArgs e)
        {
            // Переключение на полноэкранный режим
            if (WindowState == WindowState.Normal)
            {
                WindowStyle = WindowStyle.None;
                WindowState = WindowState.Maximized;
                mediaElement.Stretch = Stretch.Uniform; //Убедитесь, что элемент медиа занимает всю область
                mediaElement.Height = double.NaN;
            }
            else
            {
                WindowStyle = WindowStyle.SingleBorderWindow;
                WindowState = WindowState.Normal;
                mediaElement.Height = 550;
            }
        }

        // Обработка нажатия клавиш, чтобы можно было выйти из полноэкранного режима нажатием клавиши ESC
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                WindowStyle = WindowStyle.SingleBorderWindow;
                WindowState = WindowState.Normal;
            }
        }

        
    }
}
