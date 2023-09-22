using System.Collections.ObjectModel;
using System.ComponentModel;
using MangaVerse.Models;

namespace MangaVerse
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<CarouselItem> ImageItems { get; set; }
        public ObservableCollection<Manga> Mangas { get; set; } // Agrega la propiedad para los mangas

        public HomeViewModel()
        {
            ImageItems = new ObservableCollection<CarouselItem>();
            LoadImages();
            LoadMangas(); // Llama a la función para cargar mangas
        }

        private void LoadImages()
        {
            // Carga tus imágenes como lo estabas haciendo
            ImageItems.Add(new CarouselItem { ImagePath = "naruto.jpg" });
            ImageItems.Add(new CarouselItem { ImagePath = "onepiece.jpg" });
            ImageItems.Add(new CarouselItem { ImagePath = "kimetsu.jpg" });
            // Agrega más imágenes aquí
        }

        private void LoadMangas()
        {
            // Carga tus mangas aquí, asegúrate de que los nombres de las propiedades coincidan con tus datos reales
            Mangas = new ObservableCollection<Manga>
            {
                new Manga
                {
                    ImagePath = "diasporaiser.jpg",
                    Title = "Manga 1",
                    Author = "Autor 1",
                    Chapters = new ObservableCollection<Chapter>
                    {
                        new Chapter { Title = "Capítulo 1", Number = 1 },
                        new Chapter { Title = "Capítulo 2", Number = 2 }
                    }
                },
                new Manga
                {
                    ImagePath = "tsurukoreturnsthefavor.jpg",
                    Title = "Manga 1",
                    Author = "Autor 1",
                    Chapters = new ObservableCollection<Chapter>
                    {
                        new Chapter { Title = "Capítulo 1", Number = 1 },
                        new Chapter { Title = "Capítulo 2", Number = 2 }
                    }
                },
                new Manga
                {
                    ImagePath = "wildstrawberry.jpg",
                    Title = "Manga 1",
                    Author = "Autor 1",
                    Chapters = new ObservableCollection<Chapter>
                    {
                        new Chapter { Title = "Capítulo 1", Number = 1 },
                        new Chapter { Title = "Capítulo 2", Number = 2 }
                    }
                },
                new Manga
                {
                    ImagePath = "skeletondouble.jpg",
                    Title = "Manga 1",
                    Author = "Autor 1",
                    Chapters = new ObservableCollection<Chapter>
                    {
                        new Chapter { Title = "Capítulo 1", Number = 1 },
                        new Chapter { Title = "Capítulo 2", Number = 2 }
                    }
                },
                new Manga
                {
                    ImagePath = "tokyoghoulre.jpg",
                    Title = "Manga 1",
                    Author = "Autor 1",
                    Chapters = new ObservableCollection<Chapter>
                    {
                        new Chapter { Title = "Capítulo 1", Number = 1 },
                        new Chapter { Title = "Capítulo 2", Number = 2 }
                    }
                },
                new Manga
                {
                    ImagePath = "boruto.jpg",
                    Title = "Manga 1",
                    Author = "Autor 1",
                    Chapters = new ObservableCollection<Chapter>
                    {
                        new Chapter { Title = "Capítulo 1", Number = 1 },
                        new Chapter { Title = "Capítulo 2", Number = 2 }
                    }
                },
                // Agrega más mangas aquí
            };
        }

        // Implementa INotifyPropertyChanged para notificar a la vista de cambios en las propiedades
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}