namespace DataStore.Core.ViewModels
{
    public class CountryViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string CountryCode { get; set; }

        public string CurrencyCode { get; set; }

        public bool IsDefault { get; set; }

    }
}
