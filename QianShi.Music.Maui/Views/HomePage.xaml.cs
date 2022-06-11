using QianShi.Music.Maui.ViewModels;

namespace QianShi.Music.Maui.Views;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}