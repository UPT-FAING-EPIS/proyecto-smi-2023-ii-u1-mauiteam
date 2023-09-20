namespace MangaVerse.Views;

    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
            await Navigation.PushAsync(new SplashPage());
            await Task.Delay(2000);
            await Navigation.PushAsync(new RegisterPage());


    }
    private async void OnLoginClicked(object sender, EventArgs e)
    {
            //await Navigation.PushModalAsync(new SplashPage());
            await Navigation.PushAsync(new SplashPage());
            await Task.Delay(2000);
            await Navigation.PushAsync(new HomePage());
    }
}
