using QianShi.Music.Maui.ViewModels.Dashboard;

namespace QianShi.Music.Maui.Views.Dashboard;

public partial class MyPage : ContentPage
{
	public MyPage(MyPageViewMdoel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}