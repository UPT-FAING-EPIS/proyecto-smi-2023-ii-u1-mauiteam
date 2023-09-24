using System.Collections.ObjectModel;
using System.ComponentModel;
using MangaVerse.Models;

namespace MangaVerse
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<CarouselItem> ImageItems { get; set; }
        public ObservableCollection<Manga> Mangas { get; set; }
        public ObservableCollection<TopManga> TopMangas { get; set; }

        public HomeViewModel()
        {
            ImageItems = new ObservableCollection<CarouselItem>();
            Mangas = new ObservableCollection<Manga>();
            TopMangas = new ObservableCollection<TopManga>();

            LoadImages();
            LoadMangas();
            LoadTopMangas();
        }

        private void LoadImages()
        {
            ImageItems.Add(new CarouselItem { ImageCarousel = "borutoc.jpg" });
            ImageItems.Add(new CarouselItem { ImageCarousel = "one.jpg" });
            ImageItems.Add(new CarouselItem { ImageCarousel = "jujutsu.jpg" });
            ImageItems.Add(new CarouselItem { ImageCarousel = "bluelock.jpg" });
            ImageItems.Add(new CarouselItem { ImageCarousel = "man.jpg" });
        }

        private void LoadMangas()
        {
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
            };
        }

        private void LoadTopMangas()
        {
            TopMangas = new ObservableCollection<TopManga>
            {
                new TopManga
                {
                    Image = "diasporaiser.jpg",
                    Top = "#TOP 1",
                    Title = "Diasporaiser",
                    Author = "Ondori Nukui",
                },
                new TopManga
                {
                    Image = "tsurukoreturnsthefavor.jpg",
                    Top = "#TOP 2",
                    Title = "Tsuruko Returns the Favor",
                    Author = "Yokoyama Hidari",

                },
                new TopManga
                {
                    Image = "wildstrawberry.jpg",
                    Top = "#TOP 3",
                    Title = "Wild Strawberry",
                    Author = "Ire Yonemoto",
                },
                // Agrega más mangas populares aquí
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
