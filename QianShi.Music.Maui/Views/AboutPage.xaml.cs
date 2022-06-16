using QianShi.Music.Maui.ViewModels;

namespace QianShi.Music.Maui.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage(AboutPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}