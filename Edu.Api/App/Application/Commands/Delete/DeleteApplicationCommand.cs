using Edu.Infrastructure.Dtos;

using MediatR;

namespace Edu.Api.App.Application.Commands.Delete
{
    public class DeleteApplicationCommand : IRequest<ApplicationDto>
    {
        public int ApplicationId { get; }
        public DeleteApplicationCommand(int id)
        {
            ApplicationId = id;
        }
    }
}
