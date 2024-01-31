namespace Domain.Models
{
    public class Country
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string CountryCode { get; set; }

        public string CurrencyCode { get; set; }

        public bool IsDefault { get; set; }

    }
}
