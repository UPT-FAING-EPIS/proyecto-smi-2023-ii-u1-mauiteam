namespace MangaVerse.Views
{
    public partial class DescubrePage: ContentPage
    {
        private DescubreViewModel viewModel;

        public DescubrePage()
        {
            InitializeComponent();
            viewModel = new DescubreViewModel();
            BindingContext = viewModel;
        }
    }
}