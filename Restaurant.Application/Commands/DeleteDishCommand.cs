using MediatR;

namespace Restaurant.Application.Commands
{
    public class DeleteDishCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
