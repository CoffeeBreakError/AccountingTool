using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingTool.Domain.Domain.Commands;
using AccountingTool.Domain.Domain.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AccountingTool.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PositionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PositionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var query = new GetPositionsQuery();
            var res = await _mediator.Send(query);

            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(CreatePositionCommand command)
        {
            var res = await _mediator.Send(command);

            return Ok(res);
        }
    }
}
