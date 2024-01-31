using DataStore.Core.Implementation;
using DataStore.Core.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyExchangeController : ControllerBase
    {
        private readonly ICurrencyService currencyService;

        public CurrencyExchangeController(ICurrencyService currencyService)
        {
            this.currencyService = currencyService;
        }


        [HttpGet]
        public Task<IEnumerable<CurrencyExchangeRateViewModel>> Get()
        {
            var data = this.currencyService.GetCurrencyExchangeRates();
            return data;
        }

    }
}
