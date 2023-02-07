using System;
using System.Collections.Generic;

namespace Core.Data.Domain.TechnicalDbModel
{
    public partial class Project
    {
        public Project()
        {
            DeviceLogical = new HashSet<DeviceLogical>();
        }

        public int ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int TechId { get; set; }
        public bool Disabled { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public string UpdateUserName { get; set; }

        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual Tech Tech { get; set; }
        public virtual ICollection<DeviceLogical> DeviceLogical { get; set; }
    }
}
