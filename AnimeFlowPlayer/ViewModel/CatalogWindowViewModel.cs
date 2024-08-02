using AnimeFlowPlayer.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace AnimeFlowPlayer.ViewModel
{
    public class CatalogWindowViewModel
    {
        public ObservableCollection<Film> films { get; set; }

        public CatalogWindowViewModel()
        {
            films = new ObservableCollection<Film>();
        }

        public void FillCatalog(string path)
        {
            films.Clear();

            List<string> filmsNames = new List<string>();
            Dictionary<string, string> filmsImages = new Dictionary<string, string>();

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            DirectoryInfo[] directories = directoryInfo.GetDirectories();

            foreach (DirectoryInfo directory in directories)
            {
                filmsNames.Add(directory.Name);

                // Предполагаем, что изображение с превью для фильма имеет тот же префикс имени
                foreach (FileInfo file in directory.GetFiles())
                {
                    if (file.Name.EndsWith("_preview.jpg"))
                    {
                        // Используем имя директории как ключ для удобного получения изображения
                        filmsImages[directory.Name] = file.FullName;
                    }
                }
            }

            // Добавляем фильмы, если найдено соответствующее изображение
            foreach (string filmName in filmsNames)
            {
                if (filmsImages.TryGetValue(filmName, out string filmImage))
                {
                    films.Add(new Film(filmName, filmImage));
                }
            }
        }
    }
    public class Film
    {
        public string Title { get; set; }
        public string Image { get; set; }

        public Film(string title, string imageName)
        {
            Title = title;
            Image = imageName;
        }
    }
}
