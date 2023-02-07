using AutoMapper;

namespace WebAPI.AutoMapper
{
    public partial class WebApiProfile : Profile
    {
        public WebApiProfile()
        {
            CreateProjectProfile();
            CreateCommonProfile();
        }
    }
}