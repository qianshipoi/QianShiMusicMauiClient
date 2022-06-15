#define WINDOWS

using CommunityToolkit.Maui;

using Microsoft.Maui.LifecycleEvents;

using QianShi.Music.Maui.ViewModels;
using QianShi.Music.Maui.Views;
using QianShi.Music.Maui.Views.Dashboard;

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

        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<LoginPageViewModel>();

        builder.Services.AddSingleton<DashboardPage>();
        builder.Services.AddSingleton<DashboardPageViewModel>();

        builder.Services.AddSingleton<LoadingPage>();
        builder.Services.AddSingleton<LoadingPageViewModel>();

        return builder.Build();
    }
}
