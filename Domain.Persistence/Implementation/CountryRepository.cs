using Domain.Models;
using Domain.Persistence.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Persistence.Implementation
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DataStoreDbContext dbContext) : base(dbContext)
        {
        }
    }
}
