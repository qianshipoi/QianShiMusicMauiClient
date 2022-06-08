namespace QianShi.Music.Maui.ViewModels.Base
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string _title;

        [ObservableProperty]
        string _isBusy;
    }
}
