using FluentValidation;

namespace Contest_central.Application.DTOs.Users.Validator
{
    public class UpdateUserValidator : AbstractValidator<CreateUserDto>
    {
        private readonly IUserValidator _userValidator;
        
        public UpdateUserValidator(IUserValidator userValidator)
        {
            _userValidator = userValidator;
            Include(new IUserValidator());
            RuleFor(u => u.Id)
            .NotEmpty().WithMessage("{PropertyName} must required");

        }

    }
}
