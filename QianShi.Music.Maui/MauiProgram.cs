#define WINDOWS

using CommunityToolkit.Maui;

using Microsoft.Maui.LifecycleEvents;

using QianShi.Music.Maui.ViewModels;
using QianShi.Music.Maui.Views;

namespace QianShi.Music.Maui;


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
            })
            .UseMauiCommunityToolkit();

        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MainPageViewModel>();
        builder.Services.AddTransient<LoginPageViewModel>();
        builder.Services.AddTransient<LoginPage>();

        return builder.Build();
    }
}
