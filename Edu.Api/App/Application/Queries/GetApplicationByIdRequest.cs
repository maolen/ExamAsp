using MediatR;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edu.Api.App.Application.Queries
{
    public class GetApplicationByIdRequest : IRequest<Domain.Model.Application>
    {
        public int ApplicationId { get; set; }

        public GetApplicationByIdRequest(int id)
        {
            ApplicationId = id;
        }
    }
}
