using AutoMapper;
using MediatR;
using Restaurant.Application.Contracts.Persistence;

namespace Restaurant.Application.Commands.Handlers
{
    public class DeleteDishCommandHandler : IRequestHandler<UpdateDishCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteDishCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateDishCommand request, CancellationToken cancellationToken)
        {
            var dish = await _unitOfWork.DishRepository.Get(request.Id);

            if (dish != null)
            {
                _mapper.Map(request.DishRequestDto, dish);
                await _unitOfWork.DishRepository.Delete(dish);
                await _unitOfWork.Save();
            }

            return Unit.Value;
        }
    }
}
