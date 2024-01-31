using DataStore.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore.Core.Implementation
{
    public interface IProductService
    {
        Task<IEnumerable<ProductsViewModel>> GetProducts();

        Task<IEnumerable<ProductsViewModel>> GetUpdatedPrice(string countryCode,double conversionRate);

    }
}
