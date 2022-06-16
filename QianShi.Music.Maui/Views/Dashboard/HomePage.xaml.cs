using QianShi.Music.Maui.ViewModels.Dashboard;

namespace QianShi.Music.Maui.Views.Dashboard;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}