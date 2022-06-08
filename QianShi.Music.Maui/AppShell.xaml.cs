using QianShi.Music.Maui.Views;

namespace QianShi.Music.Maui;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(LoginPage),typeof(LoginPage));
        Routing.RegisterRoute(nameof(MainPage),typeof(MainPage));
    }
}
