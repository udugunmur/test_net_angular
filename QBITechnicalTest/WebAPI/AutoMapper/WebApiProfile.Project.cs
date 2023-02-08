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
                .ForMember(dst => dst.Country, src => src.MapFrom(y => y.Country))
                .ForMember(dst => dst.State, src => src.MapFrom(y => y.State))
                .ForMember(dst => dst.Tech, src => src.MapFrom(y => y.Tech));
        }
    }
}