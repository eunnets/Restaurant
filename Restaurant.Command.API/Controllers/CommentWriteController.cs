using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Application.Commands;
using Restaurant.Application.DTOs;

namespace Restaurant.Command.API.Controllers
{
    [Route("api/write/comment")]
    [ApiController]
    public class CommentWriteController : ControllerBase
    {
        private readonly ILogger<CommentWriteController> _logger;
        private readonly IMediator _mediator;

        public CommentWriteController(ILogger<CommentWriteController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateCommentRequestDto request)
        {
            var command = new CreateCommentCommand { CommentRequestDto = request };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }
    }
}
