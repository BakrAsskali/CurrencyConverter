using System;
namespace CurrencyConverter.Maui.Models
{
    public class Currency
    {
        public Currency(string title, decimal rate)
        {
            Title = title;
            Rate = rate;
        }

        public string Title { get; set; }
        public decimal Rate { get; set; }
    }
}

