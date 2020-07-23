
using Edu.Infrastructure.Dtos;

using MediatR;

namespace Edu.Api.App.Application.Commands.Create
{
    public class CreateApplicationCommand : IRequest<ApplicationDto>
    {
        public ApplicationDto ApplicationDto { get; }

        public CreateApplicationCommand(ApplicationDto applicationDto)
        {
            ApplicationDto = applicationDto;
        }
    }
}
