using DataStore.Core.Extensions;
using DataStore.Core.Implementation;
using DataStore.Core.ViewModels;
using Domain.Persistence.Contract;

namespace DataStore.Core.Concrete
{
    public class CurrencyService : ICurrencyService
    {

        private readonly ICurrencyExchangeRateRepository _currencyExchangeRepository;

        public CurrencyService(ICurrencyExchangeRateRepository currencyExchangeRepository)
        {
            _currencyExchangeRepository = currencyExchangeRepository;
        }

        public async Task<IEnumerable<CurrencyExchangeRateViewModel>> GetCurrencyExchangeRates()
        {
            var data = await _currencyExchangeRepository.GetAll();

            return data.ConvertToCurrencyExchangeRateModel();
        }
    }
}
