using MediatR;
using Restaurant.Application.DTOs;

namespace Restaurant.Application.Commands
{
    public class UpdateDishCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateDishRequestDto DishRequestDto { get; set; }
    }
}
