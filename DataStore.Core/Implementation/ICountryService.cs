using DataStore.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore.Core.Implementation
{
    public interface ICountryService
    {

        Task<IEnumerable<CountryViewModel>> GetCounteries();
    }
}
