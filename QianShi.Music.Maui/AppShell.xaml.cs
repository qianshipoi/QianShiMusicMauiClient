using QianShi.Music.Maui.ViewModels;
using QianShi.Music.Maui.Views;
using QianShi.Music.Maui.Views.Dashboard;

namespace QianShi.Music.Maui;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        this.BindingContext = new AppShellViewModel();
        //Routing.RegisterRoute(nameof(LoginPage),typeof(LoginPage));
        //Routing.RegisterRoute(nameof(LoadingPage),typeof(LoadingPage));
        //Routing.RegisterRoute(nameof(DashboardPage),typeof(DashboardPage));
    }
}
