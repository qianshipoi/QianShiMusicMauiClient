using QianShi.Music.Maui.Services;
using QianShi.Music.Maui.ViewModels.Base;
using QianShi.Music.Maui.Views;

namespace QianShi.Music.Maui.ViewModels
{
    public partial class AppShellViewModel : BaseViewModel
    {
        [RelayCommand]
        async Task SingOut()
        {
            Preferences.Remove(nameof(App.UserDetails));
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }

        [RelayCommand]
        async Task MenuClick(string pageName)
        {
            await Shell.Current.Navigation.PushModalAsync(ServicesProvider.GetService<AboutPage>());
        }
    }
}
