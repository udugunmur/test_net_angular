using System;
using System.Collections.Generic;

namespace Core.Data.Domain.TechnicalDbModel
{
    public partial class DeviceLogical
    {
        public DeviceLogical()
        {
            InverseParent = new HashSet<DeviceLogical>();
        }

        public int DeviceLogicalId { get; set; }
        public int DeviceTypeId { get; set; }
        public int? ParentId { get; set; }
        public int ProjectId { get; set; }
        public string DeviceLogicalName { get; set; }
        public string AssetCode { get; set; }
        public bool Disabled { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public string UpdateUserName { get; set; }

        public virtual DeviceType DeviceType { get; set; }
        public virtual DeviceLogical Parent { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<DeviceLogical> InverseParent { get; set; }
    }
}
