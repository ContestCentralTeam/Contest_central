using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contest_central.Application.Persistence.Contracts;
using FluentValidation;

namespace Contest_central.Application.DTOs.Problems.Validator
{
    public class IProblemValidator: AbstractValidator<CreateProblemDto>
    {
        private readonly IProblemRepository _problemRepository;

        public IProblemValidator(IProblemRepository problemRepository)
        {
            _problemRepository = problemRepository;

            RuleFor(n => n.Name)
                .NotEmpty()
                .WithMessage("Name is required")
                .MaximumLength(50)
                .WithMessage("Name must not exceed 100 characters");
            
            RuleFor(c => c.Country)
                .NotEmpty()
                .WithMessage("Country is required")
                .MaximumLength(50)
                .WithMessage("Country must not exceed 100 characters");
            
            RuleFor(u => u.University)
                .NotEmpty()
                .WithMessage("University is required")
                .MaximumLength(50)
                .WithMessage("University must not exceed 100 characters");
            
            RuleFor(u => u.Url)
                .NotEmpty()
                .WithMessage("Url is required")
                .MaximumLength(50)
                .WithMessage("Url must not exceed 100 characters");
        }
        
    }
}