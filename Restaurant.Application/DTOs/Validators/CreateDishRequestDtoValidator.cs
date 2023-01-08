using FluentValidation;

namespace Restaurant.Application.DTOs.Validators
{
    public class CreateDishRequestDtoValidator : AbstractValidator<CreateDishRequestDto>
    {
        public CreateDishRequestDtoValidator()
        {
            RuleFor(request => request.Name).NotEmpty();
            RuleFor(request => request.Image).NotEmpty();
            RuleFor(request => request.Category).NotEmpty();
            RuleFor(request => request.Label).NotEmpty();
            RuleFor(request => request.Description).NotEmpty();
            RuleFor(request => request.CreatedBy).NotEmpty();
        }
    }
}
