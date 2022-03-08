using AutoMapper;
using WebAPI.Models;
using Global.Models;

namespace WebAPI.Setup
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, ApplicationUserDTO>().ReverseMap();
        }
    }
}
