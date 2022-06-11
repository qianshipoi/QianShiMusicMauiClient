using QianShi.Music.Maui.ViewModels;

namespace QianShi.Music.Maui;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}

