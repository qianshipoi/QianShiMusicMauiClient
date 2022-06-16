using QianShi.Music.Maui.ViewModels.Dashboard;

namespace QianShi.Music.Maui.Views.Dashboard;

public partial class DashboardPage : ContentPage
{
	public DashboardPage(DashboardPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}