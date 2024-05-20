using CurrencyConverter.Maui.ViewModels;

namespace CurrencyConverter.Maui.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel mainViewModel)
    {
        InitializeComponent();
        BindingContext = mainViewModel;
    }
}
