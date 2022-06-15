using Newtonsoft.Json;

using QianShi.Music.Maui.Models;
using QianShi.Music.Maui.ViewModels.Base;
using QianShi.Music.Maui.Views.Dashboard;

namespace QianShi.Music.Maui.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        string _account;

        [ObservableProperty]
        string _password;

        [RelayCommand]
        async Task Login()
        {
            if (!string.IsNullOrWhiteSpace(Account) && !string.IsNullOrWhiteSpace(Password))
            {
                var userDetails = new UserBasicInfo()
                {
                    Email = Account,
                    Name = "Kuriyam"
                };
                if(Preferences.ContainsKey(nameof(App.UserDetails)))
                {
                    Preferences.Remove(nameof(App.UserDetails));
                }
                Preferences.Set(nameof(App.UserDetails), JsonConvert.SerializeObject(userDetails));
                App.UserDetails = userDetails;
                await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("提示","账号或密码为空","OK");
            }
        }
    }
}
