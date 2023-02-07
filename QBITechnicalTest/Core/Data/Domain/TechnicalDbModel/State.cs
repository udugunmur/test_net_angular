using System;
using System.Collections.Generic;

namespace Core.Data.Domain.TechnicalDbModel
{
    public partial class State
    {
        public State()
        {
            Project = new HashSet<Project>();
        }

        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string StateName { get; set; }
        public string StateCodeIso2 { get; set; }
        public string StateCodeIso3 { get; set; }
        public string Translations { get; set; }
        public bool Disabled { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public string UpdateUserName { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Project> Project { get; set; }
    }
}
