using QianShi.Music.Maui.Models;
using QianShi.Music.Maui.ViewModels.Base;

using System.Collections.ObjectModel;

namespace QianShi.Music.Maui.ViewModels.Dashboard
{
    public partial class HomePageViewModel : BaseViewModel
    {
        public ObservableCollection<Carousel> Values { get; } = new();

        public HomePageViewModel()
        {
            Values.Add(new Carousel
            {
                Name = "aqua",
                Path = "https://oss.kuriyama.top/static/akua.png"
            });

            Values.Add(new Carousel
            {
                Name = "nakiri",
                Path = "https://oss.kuriyama.top/static/nakiri.png"
            });

            Values.Add(new Carousel
            {
                Name = "kuriyama",
                Path = "https://oss.kuriyama.top/static/kuriyama.jpg"
            });
        }
    }
}
