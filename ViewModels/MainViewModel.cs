using CommunityToolkit.Mvvm.ComponentModel;
using CurrencyConverter.Maui.Services;
using CurrencyConverter.Maui.Models;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace CurrencyConverter.Maui.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        
        [ObservableProperty]
        decimal _moroccanDirhams;

        [ObservableProperty]
        decimal _convertedAmount;

        [ObservableProperty]
        Currency _selectedCurrency;

        [ObservableProperty]
        string _resultText;

        public ObservableCollection<Currency> Currencies { get; private set; } = new();

        public MainViewModel(INavigationService navigationService) : base(navigationService)
        {
            Currencies.Add(new Currency("US Dollar", 1.0m));
            Currencies.Add(new Currency("Euro", 0.91m));
            Currencies.Add(new Currency("British Pounds", 0.69m));
            Currencies.Add(new Currency("Japanese Yen", 86.56m));
        }


        [RelayCommand]
        public void Compute()
        {
            if (SelectedCurrency != null)
            {
                ConvertedAmount = MoroccanDirhams * SelectedCurrency.Rate;
                ResultText = $"{MoroccanDirhams} MAD is {ConvertedAmount} {SelectedCurrency.Title}";
            }
            else
            {
                ResultText = "Please select a currency first.";
            }
        }
    }
}

