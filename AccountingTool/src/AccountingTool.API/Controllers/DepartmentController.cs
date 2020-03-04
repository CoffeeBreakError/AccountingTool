using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountingTool.Domain.Domain.Queries.Departments;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountingTool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DepartmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Department
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetDepartmentsQuery();
            var departments = await _mediator.Send(query);

            return Ok(departments);
        }

    }
}
