using AutoMapper;
using SoulMate.Server.Entities;
using SoulMate.Shared.UserModule;

namespace SoulMate.Server.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, LoginDto>();
        }
    }
}
