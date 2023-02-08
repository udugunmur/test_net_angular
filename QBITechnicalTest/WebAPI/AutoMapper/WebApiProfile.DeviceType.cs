using AutoMapper;
using Core.Data.Domain.TechnicalDbModel;
using WebAPI.ViewModels;

namespace WebAPI.AutoMapper
{
    public partial class WebApiProfile : Profile
    {
        public void CreateDeviceTypeProfile()
        {
            CreateMap<DeviceType, DeviceTypeViewModel>();
        }
    }
}