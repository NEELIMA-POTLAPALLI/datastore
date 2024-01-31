namespace Domain.Models
{
    public class CurrencyExchangeRates
    {
        public Guid Id { get; set; }

        public double ExchangeRate { get; set; }

        public string CurrencyCode { get; set; }

        public DateTime ValidFromDate { get; set; }

        public DateTime ValidToDate { get; set; }
    }
}
