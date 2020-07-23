using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.DataAccess;
using Domain.Model;
using MediatR;
using Edu.Api.App.Application.Queries;
using Edu.Api.App.Application.Commands.Delete;
using Edu.Api.App.Application.Commands.Update;
using Edu.Infrastructure.Dtos;
using Edu.Api.App.Application.Commands.Create;

namespace Edu.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ApplicationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Application>> GetApplication(int id)
        {
            var request = new GetApplicationByIdRequest(id);
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, ApplicationDto applicationDto)
        {
            var request = new UpdateApplicationCommand(id, applicationDto);
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<Application>> Create(ApplicationDto applicationDto)
        {
            var request = new CreateApplicationCommand(applicationDto);
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Application>> Delete(int id)
        {
            var request = new DeleteApplicationCommand(id);
            var response = await _mediator.Send(request);
            return Ok(response);
        }

    }
}
