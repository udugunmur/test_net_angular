using System.Collections.Generic;

namespace WebAPI.ViewModels
{
    public class CountryViewModel
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCodeIso2 { get; set; }
        public string CountryCodeIso3 { get; set; }
        public string CountryCallingCode { get; set; }
        public int? CurrencyId { get; set; }

        public CurrencyViewModel Currency { get; set; }
        public IEnumerable<StateViewModel> State { get; set; }
    }
}
