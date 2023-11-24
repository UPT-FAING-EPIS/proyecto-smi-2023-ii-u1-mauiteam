using System.Collections.ObjectModel;
using System.ComponentModel;
using MangaVerse.Models;
using MangaVerse.Services.api;

namespace MangaVerse
{
    public class DescubreViewModel : INotifyPropertyChanged
    {

        private readonly IMangaSearch _mangaSearch;
        public ObservableCollection<MangasSearch> SearchResults { get; set; } = new ObservableCollection<MangasSearch>();

        public DescubreViewModel(IMangaSearch searchService)
        {
            _mangaSearch = searchService;
        }
        public async Task SearchMangas(string keyword)
        {
            var searchResults = await _mangaSearch.Search(keyword);
            SearchResults.Clear();
            foreach (var result in searchResults)
            {
                SearchResults.Add(result);
            }
        }


        // INotifyPropertyChanged para notificar a la vista de cambios en las propiedades
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
