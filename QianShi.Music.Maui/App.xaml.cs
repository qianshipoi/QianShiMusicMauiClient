using QianShi.Music.Maui.Models;
using QianShi.Music.Maui.Views;
using QianShi.Music.Maui.Views.Dashboard;

namespace QianShi.Music.Maui;

public partial class App : Application
{
	public static UserBasicInfo UserDetails;

	public App()
	{
		InitializeComponent();
		MainPage = new AppShell();
    }
}
