using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Persistence
{
    public class DataStoreDbContext : DbContext
    {

        public DataStoreDbContext(DbContextOptions<DataStoreDbContext> options)
           : base(options)
        {
            this.LoadInitialProducts();
            this.LoadInitialCountry();
            this.LoadCurrencyExchangeRate();
        }

        public DbSet<Products> Products { get; set; }

        public DbSet<CurrencyExchangeRates> CurrencyExchangeRates { get; set; }

        public DbSet<Country> Country { get; set; }

        public void LoadInitialProducts()
        {
            List<Products> products = new List<Products>();

            if(this.Products.Count() > 0)
            {
                return;
            }

            products.Add(new Products()
            {
                Id = Guid.NewGuid(),
                Name = "TShirt",
                Description = "Mens t-shirt, size medium",
                Price = 19.99
            });

            products.Add(new Products()
            {
                Id = Guid.NewGuid(),
                Name = "Jeans",
                Description = "Women Jeans, size medium",
                Price = 45.99
            });

            products.Add(new Products()
            {
                Id = Guid.NewGuid(),
                Name = "Hat",
                Description = "Summer Hat, one size",
                Price = 10.99
            });

            products.Add(new Products()
            {
                Id = Guid.NewGuid(),
                Name = "Coat",
                Description = "Unisex Winter Jacket, size large",
                Price = 80.99
            });

            products.Add(new Products()
            {
                Id = Guid.NewGuid(),
                Name = "Trainers",
                Description = "Women fashion footwear, size 37",
                Price = 55.99
            });



            foreach (var product in products)
            {
               
                this.Products.Add(product);
            }

            this.SaveChanges();
        }

        public void LoadInitialCountry()
        {
            List<Country> counteries = new List<Country>();

            if (this.Country.Count() > 0)
            {
                return;
            }


            counteries.Add(new Country()
            {
                Id = Guid.NewGuid(),
                CountryCode = "USA",
                CurrencyCode = "USD",
                Name="United States of America",
                IsDefault = false
            });

            counteries.Add(new Country()
            {
                Id = Guid.NewGuid(),
                CountryCode = "DEU",
                CurrencyCode = "EUR",
                Name = "Deutschland",
                IsDefault = true

            });

            counteries.Add(new Country()
            {
                Id = Guid.NewGuid(),
                CountryCode = "AUS",
                CurrencyCode = "AUD",
                Name = "Australia",
                IsDefault = false

            });

            foreach (var country in counteries)
            {

                this.Country.Add(country);
            }

            this.SaveChanges();
        }

        public void LoadCurrencyExchangeRate()
        {
            List<CurrencyExchangeRates> currencyExchangeRates = new List<CurrencyExchangeRates>();

            if(this.CurrencyExchangeRates.Count() > 0)
            {
                return;
            }

            currencyExchangeRates.Add(new CurrencyExchangeRates()
            {
                Id = Guid.NewGuid(),
                ExchangeRate = 1.29,
                CurrencyCode = "USD",
                ValidFromDate = new DateTime(2023, 01, 11),
                ValidToDate = new DateTime(2024, 03, 31),

            }) ;

            currencyExchangeRates.Add(new CurrencyExchangeRates()
            {
                Id = Guid.NewGuid(),
                ExchangeRate = 1.16,
                CurrencyCode = "EUR",
                ValidFromDate = new DateTime(2023, 01, 11),
                ValidToDate = new DateTime(2024, 03, 31),

            });

            currencyExchangeRates.Add(new CurrencyExchangeRates()
            {
                Id = Guid.NewGuid(),
                ExchangeRate = 1.87,
                CurrencyCode = "AUD",
                ValidFromDate = new DateTime(2023, 01, 11),
                ValidToDate = new DateTime(2024, 03, 31),

            });

            foreach (var exchangeRate in currencyExchangeRates)
            {
                this.CurrencyExchangeRates.Add(exchangeRate);
            }
            this.SaveChanges();
        }
    }
}
