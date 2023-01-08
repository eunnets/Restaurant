using AutoMapper;
using MediatR;
using Restaurant.Application.Contracts.Persistence;
using Restaurant.Application.DTOs;

namespace Restaurant.Application.Queries.Handlers
{
    public class GetDishByIdQueryHandler : IRequestHandler<GetDishByIdQuery, DishDto>
    {
        private readonly IDishRepository _dishRepository;
        private readonly IMapper _mapper;

        public GetDishByIdQueryHandler(IDishRepository dishRepository, IMapper mapper)
        {
            _dishRepository = dishRepository;
            _mapper = mapper;
        }

        public async Task<DishDto> Handle(GetDishByIdQuery request, CancellationToken cancellationToken)
        {
            var dish = await _dishRepository.Get(request.Id);
            return _mapper.Map<DishDto>(dish);
        }
    }
}
