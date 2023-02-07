using AutoMapper;
using Core.Data.Domain.TechnicalDbModel;
using WebAPI.ViewModels;

namespace WebAPI.AutoMapper
{
    public partial class WebApiProfile : Profile
    {
        public void CreateProjectProfile()
        {
            CreateMap<Project, ProjectViewModel>()
                .ForMember(dst => dst.Country, src => src.MapFrom(y => y.Country == null ? y.CountryId.ToString() : y.Country.CountryName))
                .ForMember(dst => dst.State, src => src.MapFrom(y => y.State == null ? y.StateId.ToString() : y.State.StateName))
                .ForMember(dst => dst.Tech, src => src.MapFrom(y => y.Tech == null ? y.TechId.ToString() : y.Tech.TechName));
        }
    }
}