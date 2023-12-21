using FluentValidation;

namespace Contest_central.Application.DTOs.Users.Validator
{
    public class IUserValidator: AbstractValidator<IUserDto>
    {
        public IUserValidator() {

            RuleFor(user => user.Name)
            .NotEmpty().WithMessage("{PropertyName} is required! ")
            .NotNull()
            .MaximumLength(50).WithMessage("{PropertyName} length should be less than 50 characters ");

            
        }
    }
}
