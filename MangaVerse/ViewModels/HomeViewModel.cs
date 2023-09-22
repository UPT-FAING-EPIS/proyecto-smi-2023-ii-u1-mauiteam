using System.Collections.ObjectModel;
using System.ComponentModel;
using MangaVerse.Models;

namespace MangaVerse
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<CarouselItem> ImageItems { get; set; }

        public HomeViewModel()
        {
            ImageItems = new ObservableCollection<CarouselItem>();
            LoadImages();
        }

        private void LoadImages()
        {
            // Aquí deberías cargar tus imágenes en ImageItems
            ImageItems.Add(new CarouselItem { ImagePath = "naruto.jpg" });
            ImageItems.Add(new CarouselItem { ImagePath = "onepiece.jpg" });
            ImageItems.Add(new CarouselItem { ImagePath = "kimetsu.jpg" });
            // Agrega más imágenes aquí
        }

        // Implementa INotifyPropertyChanged para notificar a la vista de cambios en las propiedades
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
