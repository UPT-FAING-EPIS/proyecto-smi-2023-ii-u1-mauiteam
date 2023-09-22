using System.Collections.ObjectModel;
using System.ComponentModel;
using MangaVerse.Models;

namespace MangaVerse
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<CarouselItem> ImageItems { get; set; }
        public ObservableCollection<Manga> Mangas { get; set; } // Agrega la propiedad para los mangas
        public ObservableCollection<Manga> TopMangas { get; set; }

        public HomeViewModel()
        {
    ImageItems = new ObservableCollection<CarouselItem>();
    LoadImages();
    Mangas = new ObservableCollection<Manga>(); // Inicializa Mangas
    LoadMangas();
    TopMangas = new ObservableCollection<Manga>(); // Inicializa TopMangas
    LoadTopMangas();
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
                    Title = "Diasporaiser",
                    Author = "Ondori Nukui",
                    Chapters = new ObservableCollection<Chapter>
                    {
                        new Chapter { Title = "Capítulo 1", Number = 1 },
                        new Chapter { Title = "Capítulo 2", Number = 2 }
                    }
                },
                new Manga
                {
                    ImagePath = "tsurukoreturnsthefavor.jpg",
                    Title = "Tsuruko Returns the Favor",
                    Author = "Yokoyama Hidari",
                    Chapters = new ObservableCollection<Chapter>
                    {
                        new Chapter { Title = "Capítulo 1", Number = 1 },
                        new Chapter { Title = "Capítulo 2", Number = 2 }
                    }
                },
                new Manga
                {
                    ImagePath = "wildstrawberry.jpg",
                    Title = "Wild Strawberry",
                    Author = "Ire Yonemoto",
                    Chapters = new ObservableCollection<Chapter>
                    {
                        new Chapter { Title = "Capítulo 1", Number = 1 },
                        new Chapter { Title = "Capítulo 2", Number = 2 }
                    }
                },
                new Manga
                {
                    ImagePath = "skeletondouble.jpg",
                    Title = "Skeleton Double",
                    Author = "Tokaku Kondo",
                    Chapters = new ObservableCollection<Chapter>
                    {
                        new Chapter { Title = "Capítulo 1", Number = 1 },
                        new Chapter { Title = "Capítulo 2", Number = 2 }
                    }
                },
                new Manga
                {
                    ImagePath = "tokyoghoulre.jpg",
                    Title = "Tokyo Ghoul: re",
                    Author = "Sui Ishida",
                    Chapters = new ObservableCollection<Chapter>
                    {
                        new Chapter { Title = "Capítulo 1", Number = 1 },
                        new Chapter { Title = "Capítulo 2", Number = 2 }
                    }
                },
                new Manga
                {
                    ImagePath = "boruto.jpg",
                    Title = "BORUTO - TWO BLUE VORTEX",
                    Author = "MASASHI KISHIMOTO / MIKIO IKEMOTO",
                    Chapters = new ObservableCollection<Chapter>
                    {
                        new Chapter { Title = "Capítulo 1", Number = 1 },
                        new Chapter { Title = "Capítulo 2", Number = 2 }
                    }
                },
                // Agrega más mangas aquí
            };
        }
        
        private void LoadTopMangas()
        {
            // Carga los top mangas en la colección TopMangas
    TopMangas.Add(new Manga { ImagePath = "diasporaiser.jpg"});
    TopMangas.Add(new Manga { ImagePath = "tsurukoreturnsthefavor.jpg"});
    TopMangas.Add(new Manga { ImagePath = "wildstrawberry.jpg"});
            // Agrega los 5 mangas más populares aquí
        }
        

        // Implementa INotifyPropertyChanged para notificar a la vista de cambios en las propiedades
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}