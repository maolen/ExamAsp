using Edu.Infrastructure.Services;

using MediatR;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Edu.Api.App.Application.Queries
{
    public class GetApplicationByIdRequestHandler : IRequestHandler<GetApplicationByIdRequest, Domain.Model.Application>
    {
        private readonly IApplicationsRepository _applicationsRepository;

        public GetApplicationByIdRequestHandler(IApplicationsRepository applicationsRepository)
        {
            _applicationsRepository = applicationsRepository;
        }

        public Task<Domain.Model.Application> Handle(GetApplicationByIdRequest request, CancellationToken cancellationToken)
        {
            var application = _applicationsRepository.GetById(request.ApplicationId);
            return application;
        }
    }
}
