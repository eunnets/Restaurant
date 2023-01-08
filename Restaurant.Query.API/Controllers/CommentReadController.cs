using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Application.DTOs;
using Restaurant.Application.Queries;

namespace Restaurant.Query.API.Controllers
{
    [Route("api/read/comment")]
    [ApiController]
    public class CommentReadController : ControllerBase
    {
        private readonly ILogger<CommentReadController> _logger;
        private readonly IMediator _mediator;

        public CommentReadController(ILogger<CommentReadController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet("{dishId}")]
        public async Task<ActionResult<CommentDto>> Get([FromQuery] int dishId)
        {
            var leaveRequest = await _mediator.Send(new GetCommentByDishIdQuery { DishId = dishId });
            return Ok(leaveRequest);
        }
    }
}
