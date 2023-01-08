using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Application.DTOs;
using Restaurant.Application.Queries;

namespace Restaurant.Query.API.Controllers
{
    [Route("api/read/dish")]
    [ApiController]
    public class DishReadController : ControllerBase
    {
        private readonly ILogger<DishReadController> _logger;
        private readonly IMediator _mediator;

        public DishReadController(ILogger<DishReadController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<DishDto>>> Get()
        {
            var dishes = await _mediator.Send(new GetDishQuery() { });
            return Ok(dishes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DishDto>> Get([FromQuery] int id)
        {
            var leaveRequest = await _mediator.Send(new GetDishByIdQuery { Id = id });
            return Ok(leaveRequest);
        }
    }
}
