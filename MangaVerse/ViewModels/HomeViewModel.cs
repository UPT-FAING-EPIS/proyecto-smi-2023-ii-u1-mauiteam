namespace MangaVerse.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            ToolBarPage = new NavigationPage(new Views.ToolBarPage());
        }

    }
}
