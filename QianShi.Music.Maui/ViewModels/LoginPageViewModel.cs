using QianShi.Music.Maui.ViewModels.Base;

namespace QianShi.Music.Maui.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        string _account;

        [ObservableProperty]
        string _password;

        public LoginPageViewModel()
        {
        }

        [RelayCommand]
        async Task Login()
        {
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
    }
}
