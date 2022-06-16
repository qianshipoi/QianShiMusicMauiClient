using QianShi.Music.Maui.ViewModels;
using QianShi.Music.Maui.Views;

namespace QianShi.Music.Maui;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        this.BindingContext = new AppShellViewModel();
    }
}
