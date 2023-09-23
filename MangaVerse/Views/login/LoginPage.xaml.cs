using System;
using MangaVerse.Services;

namespace MangaVerse.Views;

    public partial class LoginPage : ContentPage
    {
        private readonly AuthService _authService;
        public LoginPage(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
            //  await Navigation.PushAsync(new SplashPage());
             await Navigation.PushAsync(new RegisterPage());
    }
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        _authService.Login();
        await Task.Delay(2000);
		await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }
}
