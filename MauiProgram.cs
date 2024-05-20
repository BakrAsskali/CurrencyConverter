using CurrencyConverter.Maui.Services;
using CurrencyConverter.Maui.ViewModels;
using CurrencyConverter.Maui.Views;
using Microsoft.Extensions.Logging;

namespace CurrencyConverter.Maui;

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
        builder.Services.AddSingleton<INavigationService, NavigationService>();

        // UI registration
        builder.Services.AddSingleton<MainPage>();

        // View-Model registration
        builder.Services.AddSingleton<MainViewModel>();
        
        return builder.Build();
	}
}

