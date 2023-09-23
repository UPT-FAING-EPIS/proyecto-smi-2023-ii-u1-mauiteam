using MangaVerse.Services;
using MangaVerse.Views;
using Microsoft.Extensions.Logging;

namespace MangaVerse;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddTransient<AuthService>();
		builder.Services.AddTransient<HomePage>();
		builder.Services.AddTransient<SplashPage>();
		builder.Services.AddTransient<LoginPage>();
		builder.Services.AddTransient<ProfilePage>();

		return builder.Build();
	}
}
