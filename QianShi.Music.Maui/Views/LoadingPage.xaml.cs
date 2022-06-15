using QianShi.Music.Maui.ViewModels;

namespace QianShi.Music.Maui.Views;

public partial class LoadingPage : ContentPage
{
	public LoadingPage(LoadingPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}