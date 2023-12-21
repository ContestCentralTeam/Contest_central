using FluentValidation;
using Contest_central.Application.DTOs.Contest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contest_central.Application.Persistence.Contracts;

namespace Contest_central.Application.DTOs.Contests.Validator;

public class CreateContestValidator : AbstractValidator<CreateContestDto>
{
    private readonly IContestRepository _contestRepository;
    public CreateContestValidator(IContestRepository contestRepository)
    {
        _contestRepository = contestRepository;
        RuleFor(n => n.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .MaximumLength(100).WithMessage("{PropertyName} is more than 100 characters");
        RuleFor(n => n.Duration)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .Must((duration, token) =>
            {
                if (duration.GetType() == typeof(int))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }).WithMessage("{PropertyName} must be int");
    }
}
