using DataStore.Core.Implementation;
using DataStore.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {

        private readonly ICountryService countryService;

        public CountryController(ICountryService countryService)
        {
            this.countryService = countryService;
        }


        [HttpGet]
        public Task<IEnumerable<CountryViewModel>> Get()
        {
            var data = this.countryService.GetCounteries();
            return data;
        }

    }
    
}
