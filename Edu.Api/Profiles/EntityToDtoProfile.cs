using Domain.Model;
using Edu.Infrastructure.Dtos;

namespace Edu.Api.Profiles
{
    public class EntityToDtoProfile : AutoMapper.Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<ApplicationDto, Application>();
        }
    }
}
