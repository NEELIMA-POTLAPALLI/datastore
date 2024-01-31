using DataStore.Core.ViewModels;
using Domain.Models;

namespace DataStore.Core.Extensions
{
    public static class ExtensionMethods
    {
        public static IEnumerable<ProductsViewModel> ConvertToProductViewModel(
            this IEnumerable<Products>? products)
        {
            List<ProductsViewModel> list = new List<ProductsViewModel>();

            foreach (var product in products)
            {
                list.Add(product.ConvertToProductViewModel());
            }

            return list;
        }

        public static ProductsViewModel ConvertToProductViewModel(
            this Products products)
        {
            return new ProductsViewModel()
            {
                Description = products.Description,
                Id = products.Id,
                Name = products.Name,
                Price = products.Price,
            };
        }


        public static IEnumerable<CountryViewModel> ConvertToCountryViewModel(
            this IEnumerable<Country>? countries)
        {
            List<CountryViewModel> list = new List<CountryViewModel>();

            foreach (var country in countries)
            {
                list.Add(country.ConvertToCountryViewModel());
            }

            return list;
        }

        public static CountryViewModel ConvertToCountryViewModel(
            this Country country)
        {
            return new CountryViewModel()
            {
                CountryCode = country.CountryCode,
                CurrencyCode = country.CurrencyCode,
                Id = country.Id,
                Name = country.Name,
                IsDefault = country.IsDefault,
            };
        }


        public static IEnumerable<CurrencyExchangeRateViewModel> ConvertToCurrencyExchangeRateModel(
          this IEnumerable<CurrencyExchangeRates>? exchangeRateList)
        {
            List<CurrencyExchangeRateViewModel> list = new List<CurrencyExchangeRateViewModel>();

            foreach (var exchangeRate in exchangeRateList)
            {
                list.Add(exchangeRate.ConvertToCurrencyExchangeRateModel());
            }

            return list;
        }

        public static CurrencyExchangeRateViewModel ConvertToCurrencyExchangeRateModel(
            this CurrencyExchangeRates exchangeList)
        {
            return new CurrencyExchangeRateViewModel()
            {
                CurrencyCode = exchangeList.CurrencyCode,
                ExchangeRate = exchangeList.ExchangeRate,
                ValidFromDate = exchangeList.ValidFromDate,
                ValidToDate = exchangeList.ValidToDate,
                Id = exchangeList.Id,
            };
        }


    }
}
