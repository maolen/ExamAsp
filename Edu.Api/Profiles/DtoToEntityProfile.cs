
using Domain.Model;

using Edu.Infrastructure.Dtos;

namespace Edu.Api.Profiles
{
    public class DtoToEntityProfile : AutoMapper.Profile
    {
        public DtoToEntityProfile()
        {
            CreateMap<Application, ApplicationDto>();
        }
    }
}
