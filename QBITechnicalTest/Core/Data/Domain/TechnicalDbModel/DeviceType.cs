using System;
using System.Collections.Generic;

namespace Core.Data.Domain.TechnicalDbModel
{
    public partial class DeviceType
    {
        public DeviceType()
        {
            DeviceLogical = new HashSet<DeviceLogical>();
        }

        public int DeviceTypeId { get; set; }
        public int? IconId { get; set; }
        public string DeviceTypeName { get; set; }
        public string Description { get; set; }
        public string Translations { get; set; }
        public bool Disabled { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public string UpdateUserName { get; set; }

        public virtual ICollection<DeviceLogical> DeviceLogical { get; set; }
    }
}
