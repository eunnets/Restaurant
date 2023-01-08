using FluentValidation;

namespace Restaurant.Application.DTOs.Validators
{
    public class UpdateDishRequestDtoValidator : AbstractValidator<UpdateDishRequestDto>
    {
        public UpdateDishRequestDtoValidator()
        {
            RuleFor(request => request.Image).NotEmpty();
            RuleFor(request => request.Category).NotEmpty();
            RuleFor(request => request.Label).NotEmpty();
            RuleFor(request => request.Description).NotEmpty();
            RuleFor(request => request.UpdatedBy).NotEmpty();
        }
    }
}
