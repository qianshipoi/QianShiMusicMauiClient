using QianShi.Music.Maui.ViewModels;
using QianShi.Music.Maui.Views;

namespace QianShi.Music.Maui;

public partial class AppShell : Shell
{
    public AppShell(AppShellViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
        Routing.RegisterRoute(nameof(LoginPage),typeof(LoginPage));
        Routing.RegisterRoute(nameof(MainPage),typeof(MainPage));
    }
}
