using AutoMapper;
using MediatR;
using Restaurant.Application.Contracts.Persistence;
using Restaurant.Domain.Entities;

namespace Restaurant.Application.Commands.Handlers
{
    public class CreateDishCommandHandler : IRequestHandler<CreateDishCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateDishCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateDishCommand request, CancellationToken cancellationToken)
        {
            var dish = _mapper.Map<Dish>(request.DishRequestDto);
            dish.Created = DateTime.Now;

            await _unitOfWork.DishRepository.Add(dish);
            await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}
