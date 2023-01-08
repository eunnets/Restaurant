using AutoMapper;
using MediatR;
using Restaurant.Application.Contracts.Persistence;
using Restaurant.Application.DTOs;

namespace Restaurant.Application.Queries.Handlers
{
    public class GetDishQueryHandler : IRequestHandler<GetDishQuery, List<DishDto>>
    {
        private readonly IDishRepository _dishRepository;
        private readonly IMapper _mapper;

        public GetDishQueryHandler(IDishRepository dishRepository, IMapper mapper)
        {
            _dishRepository = dishRepository;
            _mapper = mapper;
        }

        public async Task<List<DishDto>> Handle(GetDishQuery request, CancellationToken cancellationToken)
        {
            var dishes = await _dishRepository.GetAll();
            return _mapper.Map<List<DishDto>>(dishes);
        }
    }
}
