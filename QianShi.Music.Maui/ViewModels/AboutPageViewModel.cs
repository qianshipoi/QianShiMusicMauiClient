using QianShi.Music.Maui.ViewModels.Base;

namespace QianShi.Music.Maui.ViewModels
{
    public partial class AboutPageViewModel : BaseViewModel
    {
        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.Navigation.PopModalAsync();
        }
    }
}
