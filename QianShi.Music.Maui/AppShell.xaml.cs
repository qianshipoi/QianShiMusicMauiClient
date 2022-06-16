using QianShi.Music.Maui.ViewModels;

namespace QianShi.Music.Maui;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        this.BindingContext = new AppShellViewModel();
    }
}
