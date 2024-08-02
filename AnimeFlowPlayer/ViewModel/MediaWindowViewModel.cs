using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace AnimeFlowPlayer.ViewModel
{
    public class MediaWindowViewModel
    {
        public ObservableCollection<Video> series { get; set; }

        public MediaWindowViewModel()
        {
            series = new ObservableCollection<Video>();
        }

        public void FillCatalog(string path)
        {
            series.Clear();

            List<string> seriesNames = new List<string>();
            List<string> seriesImages = new List<string>();

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] fileInfos = directoryInfo.GetFiles();

            foreach (FileInfo file in fileInfos)
            {
                if (file.Extension.Equals(".mp4", StringComparison.OrdinalIgnoreCase))
                {
                    seriesNames.Add(file.Name);
                }
            }

            foreach (FileInfo fileImg in fileInfos)
            {
                if (fileImg.Name.EndsWith("_preview.jpg"))
                {
                    seriesImages.Add(fileImg.FullName);
                }
            }


            foreach (string filmsName in seriesNames)
            {
                foreach (string filmsImage in seriesImages)
                {
                    series.Add(new Video(filmsName, filmsImage));
                }
            }
        }
        public class Video
        {
            public string Title { get; set; }
            public string Image { get; set; }

            public Video(string title, string imageName)
            {
                Title = title;
                Image = imageName;
            }

            public override string ToString() => $"{Title}";
        }
    }

}
