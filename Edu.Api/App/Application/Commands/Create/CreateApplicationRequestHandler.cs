using AutoMapper;

using Edu.Infrastructure.Dtos;
using Edu.Infrastructure.Services;

using MediatR;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Edu.Api.App.Application.Commands.Create
{
    public class CreateApplicationRequestHandler : IRequestHandler<CreateApplicationCommand, ApplicationDto>
    {
        private readonly IApplicationsRepository _repository;
        private readonly IMapper _mapper;

        public CreateApplicationRequestHandler(IApplicationsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<ApplicationDto> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
        {
            var createdApplication = _mapper.Map<Domain.Model.Application>(request.ApplicationDto);
            _repository.Create(createdApplication);
            return _mapper.Map<ApplicationDto>(createdApplication);
        }
    }
}
