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
        public AppShellViewModel()
        {

        }


        [RelayCommand]
        async Task SingOut()
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
