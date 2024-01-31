using DataStore.Core.Extensions;
using DataStore.Core.Implementation;
using DataStore.Core.ViewModels;
using Domain.Persistence.Contract;

namespace DataStore.Core.Concrete
{
    public class CountryService : ICountryService
    {

        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<IEnumerable<CountryViewModel>> GetCounteries()
        {
            var data = await _countryRepository.GetAll();

            return data.ConvertToCountryViewModel();
        }
    }
}
