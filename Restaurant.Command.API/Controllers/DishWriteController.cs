using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Application.Commands;
using Restaurant.Application.DTOs;

namespace Restaurant.Command.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishWriteController : ControllerBase
    {
        private readonly ILogger<DishWriteController> _logger;
        private readonly IMediator _mediator;

        public DishWriteController(ILogger<DishWriteController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateDishRequestDto request)
        {
            var command = new CreateDishCommand { DishRequestDto = request };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateDishRequestDto request)
        {
            var command = new UpdateDishCommand { Id = id, DishRequestDto = request };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteDishCommand { Id = id };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }
    }
}
