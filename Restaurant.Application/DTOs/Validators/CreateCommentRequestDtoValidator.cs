using FluentValidation;

namespace Restaurant.Application.DTOs.Validators
{
    public class CreateCommentRequestDtoValidator : AbstractValidator<CreateCommentRequestDto>
    {
        public CreateCommentRequestDtoValidator()
        {
            RuleFor(request => request.DishId).NotEmpty();
            RuleFor(request => request.Rating).InclusiveBetween(1, 5);
            RuleFor(request => request.Contents).NotEmpty();
            RuleFor(request => request.CreatedBy).NotEmpty();
        }
    }
}
