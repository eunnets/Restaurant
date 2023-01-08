using MediatR;
using Restaurant.Application.DTOs;

namespace Restaurant.Application.Queries
{
    public class GetDishByIdQuery : IRequest<DishDto>
    {
        public int Id { get; set; }
    }
}
