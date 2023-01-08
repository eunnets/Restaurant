using MediatR;
using Restaurant.Application.DTOs;

namespace Restaurant.Application.Queries
{
    public class GetCommentByDishIdQuery : IRequest<List<CommentDto>>
    {
        public int DishId { get; set; }
    }
}
