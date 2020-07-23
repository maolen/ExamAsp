using Edu.Infrastructure.Dtos;

using MediatR;

namespace Edu.Api.App.Application.Commands.Update
{
    public class UpdateApplicationCommand : IRequest<ApplicationDto>
    {
        public int ApplicationId { get; }
        public ApplicationDto ApplicationDto { get;  }
        public UpdateApplicationCommand(int id, ApplicationDto applicationDto)
        {
            ApplicationId = id;
            ApplicationDto = applicationDto;
        }
    }
}
