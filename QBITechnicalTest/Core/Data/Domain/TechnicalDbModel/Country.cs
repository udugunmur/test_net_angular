using System;
using System.Collections.Generic;

namespace Core.Data.Domain.TechnicalDbModel
{
    public partial class Country
    {
        public Country()
        {
            Project = new HashSet<Project>();
            State = new HashSet<State>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCodeIso2 { get; set; }
        public string CountryCodeIso3 { get; set; }
        public string CountryCallingCode { get; set; }
        public int? CurrencyId { get; set; }
        public string Translations { get; set; }
        public bool Disabled { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public string UpdateUserName { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual ICollection<Project> Project { get; set; }
        public virtual ICollection<State> State { get; set; }
    }
}
