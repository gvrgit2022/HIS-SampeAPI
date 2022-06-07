using Microsoft.AspNetCore.Mvc;
using MediatR;
using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleAPI.Application.Test.Queries;

namespace SampleCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<TestController> _logger;

        public TestController(IMediator mediator, ILogger<TestController> logger)
        {
            this._mediator = mediator;
            this._logger = logger;
        }

        [HttpGet("GetTurotials")]
        public async Task<IActionResult> GetTutorials([FromQuery] int id)
        {
            var data = await _mediator.Send(new GetTutorialDataQuery() {TutorialId=id });
            return Ok(data);

        }
    }
}
