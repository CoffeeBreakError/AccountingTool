using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingTool.Domain.Domain.Queries.WearSize;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountingTool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WearSizeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WearSizeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetWearSizesQuery();
            var wearSizes = await _mediator.Send(query);

            return Ok(wearSizes);
        }
    }
}