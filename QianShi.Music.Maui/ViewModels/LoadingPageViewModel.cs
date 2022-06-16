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
            Check();
        }

        void Check()
        {
            var userDetailStr = Preferences.Get(nameof(App.UserDetails), string.Empty);
            if (string.IsNullOrWhiteSpace(userDetailStr))
            {
                App.Current.Dispatcher.Dispatch(async () =>
                {
                    await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
                });
            }
            else
            {
                var userInfo = JsonConvert.DeserializeObject<UserBasicInfo>(userDetailStr);
                App.UserDetails = userInfo;

                App.Current.Dispatcher.Dispatch(async () =>
                {
                    await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
                });
            }
        }
    }
}
