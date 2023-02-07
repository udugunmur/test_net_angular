using System;
using System.Collections.Generic;

namespace Core.Data.Domain.TechnicalDbModel
{
    public partial class Tech
    {
        public Tech()
        {
            Project = new HashSet<Project>();
        }

        public int TechId { get; set; }
        public string TechName { get; set; }
        public string TechShortName { get; set; }
        public string Description { get; set; }
        public string Translations { get; set; }
        public bool Disabled { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public string UpdateUserName { get; set; }

        public virtual ICollection<Project> Project { get; set; }
    }
}
