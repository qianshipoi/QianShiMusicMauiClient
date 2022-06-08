using QianShi.Music.Maui.ViewModels;

namespace QianShi.Music.Maui.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}