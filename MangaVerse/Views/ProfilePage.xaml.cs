using MangaVerse.Services;
namespace MangaVerse.Views
{
    public partial class ProfilePage: ContentPage
    {
        private readonly AuthService _authService;
        public ProfilePage(AuthService authService)
        {
            InitializeComponent();
             _authService = authService;
        }
        private void OnLoginClicked(object sender, EventArgs e)
        {
            _authService.Logout();
            Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}