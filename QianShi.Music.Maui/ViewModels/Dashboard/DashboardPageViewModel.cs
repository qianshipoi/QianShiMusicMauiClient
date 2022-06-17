using QianShi.Music.Maui.Models;
using QianShi.Music.Maui.ViewModels.Base;

namespace QianShi.Music.Maui.ViewModels.Dashboard
{
    public partial class DashboardPageViewModel : BaseViewModel
    {

        [ObservableProperty]
        List<Banner> _banners = new();

        public DashboardPageViewModel()
        {
            Banners.Add(new Banner
            {
                Name = "Kuriyama",
                ImageUrl = "https://oss.kuriyama.top/static/kuriyama.jpg"
            });


            Banners.Add(new Banner
            {
                Name = "Nakiri",
                ImageUrl = "https://oss.kuriyama.top/static/nakiri.png"
            });

            Banners.Add(new Banner
            {
                Name = "Akuq",
                ImageUrl = "https://oss.kuriyama.top/static/akua.png"
            });

        }
    }
}
