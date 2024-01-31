using Domain.Models;
using Domain.Persistence.Contract;

namespace Domain.Persistence.Implementation
{
    public class CurrencyExchangeRateRepository : GenericRepository<CurrencyExchangeRates>, ICurrencyExchangeRateRepository
    {
        public CurrencyExchangeRateRepository(DataStoreDbContext dbContext) : base(dbContext)
        {
        }
    }
}
