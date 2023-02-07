using System;
using System.Collections.Generic;

namespace Core.Data.Domain.TechnicalDbModel
{
    public partial class Currency
    {
        public Currency()
        {
            Country = new HashSet<Country>();
        }

        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyIso { get; set; }
        public string CurrencySymbol { get; set; }
        public string Translations { get; set; }
        public bool Disabled { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public string UpdateUserName { get; set; }

        public virtual ICollection<Country> Country { get; set; }
    }
}
