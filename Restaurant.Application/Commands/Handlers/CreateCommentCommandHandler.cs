using AutoMapper;
using MediatR;
using Restaurant.Application.Contracts.Persistence;
using Restaurant.Domain.Entities;

namespace Restaurant.Application.Commands.Handlers
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCommentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var comment = _mapper.Map<Comment>(request.CommentRequestDto);
            comment.Created = DateTime.Now;

            await _unitOfWork.CommentRepository.Add(comment);
            await _unitOfWork.Save();

            return Unit.Value;
        }
    }
}
