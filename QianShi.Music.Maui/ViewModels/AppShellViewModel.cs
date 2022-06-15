using QianShi.Music.Maui.ViewModels.Base;
using QianShi.Music.Maui.Views;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
