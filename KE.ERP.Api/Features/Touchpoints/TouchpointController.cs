using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatR;
using KE.ERP.Api.Features.Touchpoints.Models;
using KE.ERP.Api.Features.Touchpoints.GetAll;

namespace KE.ERP.Api.Features.Touchpoints
{
    [ApiController]
    [Route("api/[controller]")]
    public class TouchpointsController : ControllerBase
    {

        private readonly IMediator _mediator;       

        public TouchpointsController(IMediator mediator)
        {
            //_logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(TouchpointModel),200)]
        public async Task<IActionResult> Get([FromQuery]RequestCommand command)
        {
            var rng = new Random();           
            return Ok(await _mediator.Send(command));
        }
    }
}
