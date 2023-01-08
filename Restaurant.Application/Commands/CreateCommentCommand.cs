using MediatR;
using Restaurant.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Application.Commands
{
    public class CreateCommentCommand : IRequest<Unit>
    {
        public CreateCommentRequestDto CommentRequestDto { get; set; }
    }
}
