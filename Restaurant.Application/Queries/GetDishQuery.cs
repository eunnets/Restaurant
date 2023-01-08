using MediatR;
using Restaurant.Application.DTOs;

namespace Restaurant.Application.Queries
{
    public class GetDishQuery : IRequest<List<DishDto>>
    {
    }
}
