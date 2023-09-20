namespace MangaVerse.Views
{
    public partial class ToolBarPage: ContentPage
    {
        public ToolBarPage()
        {
            InitializeComponent();
        }
        private void OnMenuButtonClicked(object sender, EventArgs e)
        {
            ToolbarItem elemento = (ToolbarItem)sender;
        }
    }
}