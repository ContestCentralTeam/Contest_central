using FluentValidation;

namespace Contest_central.Application.DTOs.Users.Validator
{
    public class CreateUserValidator: AbstractValidator<IUserDto>
    {
       private readonly IUserValidator _userValidator;
        private bool IsAllowedRole(string role)
        {
            List<string> roles = new List<string> { "admin", "head_of_academy", "head_of_education", "Students" };

            return roles.Contains(role.ToLowerInvariant());
        }

       public CreateUserValidator(IUserValidator userValidator)
        {
            _userValidator = userValidator;
            Include(new IUserValidator());

            RuleFor(User => User.Email)
            .NotEmpty().WithMessage("{PropertyName} is required!")
            .EmailAddress().WithMessage("{PropertyName} is not a valid email address!")
            .Matches(@"@a2sv.org$").WithMessage("{PropertyName} must end with @a2sv.org");

            RuleFor(User => User.Password)
            .NotEmpty().WithMessage("{PropertyName} is required!")
            .MinimumLength(8).WithMessage("{PropertyName} must be 8 characters. ")
            .Matches("[A-Z]").WithMessage("Password must contain at least one uppercase latter.")
            .Matches("[a-z]").WithMessage("Password must contain at least one lowercase latter.")
            .Matches("[0-9]").WithMessage("Password must contain at least one number.")
            .Matches("[!@#$%^&*]").WithMessage("Password must contain at least one special character.");

            RuleFor(Users => Users.Role)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .Must(role => IsAllowedRole(role)).WithMessage("Invalid {PropertyName} selected. ");

        }

    }
}
