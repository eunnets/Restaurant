using MediatR;
using Restaurant.Application.DTOs;

namespace Restaurant.Application.Commands
{
    public class CreateDishCommand : IRequest<Unit>
    {
        public CreateDishRequestDto DishRequestDto { get; set; }
    }
}
