using Newtonsoft.Json;

using QianShi.Music.Maui.Models;
using QianShi.Music.Maui.ViewModels.Base;
using QianShi.Music.Maui.Views;
using QianShi.Music.Maui.Views.Dashboard;

namespace QianShi.Music.Maui.ViewModels
{
    public partial class LoadingPageViewModel : BaseViewModel
    {
        public LoadingPageViewModel()
        {
            _ = CheckUserLoginDetails();
        }

        private async Task CheckUserLoginDetails()
        {
            var userDetailStr = Preferences.Get(nameof(App.UserDetails), string.Empty);
            if (string.IsNullOrWhiteSpace(userDetailStr))
            {
                var items = AppShell.Current.Items;
                await AppShell.Current.GoToAsync($"//{nameof(LoginPage)}");
            }
            else
            {
                var userInfo = JsonConvert.DeserializeObject<UserBasicInfo>(userDetailStr);
                App.UserDetails = userInfo;
                var items = AppShell.Current.Items;
                await AppShell.Current.GoToAsync($"//{nameof(DashboardPage)}");
            }
        }
    }
}
