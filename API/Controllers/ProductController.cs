using DataStore.Core.Implementation;
using DataStore.Core.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }


        [HttpGet]
        public Task<IEnumerable<ProductsViewModel>> Get()
        {
            var data = this.productService.GetProducts();
            return data;
        }



        [HttpGet]
        [Route("getUpdatedPrice")]
        public Task<IEnumerable<ProductsViewModel>> GetUpdatedPrice(string currencyCode, double conversionValue)
        {
            var data = this.productService.GetUpdatedPrice(currencyCode,conversionValue);
            return data;
        }

    }
}
