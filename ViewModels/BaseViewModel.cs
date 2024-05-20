using CommunityToolkit.Mvvm.ComponentModel;
using CurrencyConverter.Maui.Services;

namespace CurrencyConverter.Maui.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        protected readonly INavigationService NavigationService;

        [ObservableProperty]
        string title;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotLoading))]
        bool isLoading;

        public bool IsNotLoading => !IsLoading;

        public BaseViewModel()
        {

        }

        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
    }
}

