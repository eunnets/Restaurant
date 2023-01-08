using AutoMapper;
using Restaurant.Application.Contracts.Persistence;
using Restaurant.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Application.Queries.Handlers
{
    public class GetCommentByDishIdQueryHandler
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public GetCommentByDishIdQueryHandler(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }

        public async Task<List<DishDto>> Handle(GetCommentByDishIdQuery request, CancellationToken cancellationToken)
        {
            var dishes = await _commentRepository.GetAll();
            return _mapper.Map<List<DishDto>>(dishes);
        }
    }
}
