using System;
using System.Collections.Generic;
using Core.Data.Domain.TechnicalDbModel;

namespace WebAPI.ViewModels
{
    public class DeviceTypeViewModel
    {
        public int DeviceTypeId { get; set; }
        public int? IconId { get; set; }
        public string DeviceTypeName { get; set; }
        
        public string Description { get; set; }
        public string Translations { get; set; }
        public bool Disabled { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public string UpdateUserName { get; set; }
        
        // public ICollection<DeviceLogical> DeviceLogical { get; set; }
    }
}