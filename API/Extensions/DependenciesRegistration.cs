using DataStore.Core.Concrete;
using DataStore.Core.Implementation;
using Domain.Persistence.Contract;
using Domain.Persistence.Implementation;

namespace API.Extensions
{
    public static class DependenciesRegistration
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services) 
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ICurrencyExchangeRateRepository, CurrencyExchangeRateRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();


            return services;
        }

        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICurrencyService, CurrencyService>();
            services.AddScoped<ICountryService, CountryService>();
                

            return services;
        }


    }
}
