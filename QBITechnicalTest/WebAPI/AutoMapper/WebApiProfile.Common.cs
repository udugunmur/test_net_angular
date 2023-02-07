using AutoMapper;
using Core.Data.Domain.TechnicalDbModel;
using WebAPI.ViewModels;

namespace WebAPI.AutoMapper
{
    public partial class WebApiProfile : Profile
    {
        public void CreateCommonProfile()
        {
            CreateMap<Country, CountryViewModel>();
            CreateMap<Currency, CurrencyViewModel>();
            CreateMap<State, StateViewModel>();
            CreateMap<Tech, TechViewModel>();
        }
    }
}