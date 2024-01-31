using DataStore.Core.Implementation;
using DataStore.Core.ViewModels;
using Domain.Persistence.Contract;
using DataStore.Core.Extensions;

namespace DataStore.Core.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductsViewModel>> GetProducts()
        {
            var data = await _productRepository.GetAll();

            return data.ConvertToProductViewModel();
        }

        public async Task<IEnumerable<ProductsViewModel>> GetUpdatedPrice(
            string countryCode, double conversionRate)
        {

            if (string.IsNullOrEmpty(countryCode))
            {
                throw new ArgumentNullException(nameof(countryCode), "Country Code shouldnot be null");
            }

            if (conversionRate < 0)
            {
                throw new ArgumentNullException(nameof(conversionRate), "Conversion Rate Should be greater than 0");
            }


            List<ProductsViewModel> productsViewModel
                 = new List<ProductsViewModel>();

            var data = await _productRepository.GetAll();

            if (data.Any())
            {
                foreach (var product in data)
                {
                    var currentPrice = product.Price;
                    var updatedPrice = currentPrice * conversionRate;


                    ProductsViewModel prodModel = new ProductsViewModel()
                    {
                        Price = Math.Round(updatedPrice, 2),
                        Description = product.Description,
                        Name = product.Name,
                    };

                    productsViewModel.Add(prodModel);
                }

            }

            return productsViewModel;
        }
    }
}
