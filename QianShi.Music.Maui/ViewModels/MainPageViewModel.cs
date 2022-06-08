using QianShi.Music.Maui.ViewModels.Base;
using QianShi.Music.Maui.Views;

namespace QianShi.Music.Maui.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
            Title = "MainPageTitle";
        }

        [RelayCommand]
        async Task Logout()
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }

    }
}
