using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contest_central.Application.Persistence.Contracts;
using FluentValidation;

namespace Contest_central.Application.DTOs.ProblemLogs.Validator
{
    public class IProblemLogValidator: AbstractValidator<CreateProblemLogDto>
    {
        private readonly IProblemLogRepository _problemLogRepository;

        public IProblemLogValidator(IProblemLogRepository problemLogRepository)
        {
            _problemLogRepository = problemLogRepository;

            RuleFor(n => n.Contest_id)
                .NotEmpty()
                .WithMessage("Contest_id is required");
                // .MaximumLength(50)
                // .WithMessage("Contest_id must not exceed 100 characters");
            
            RuleFor(c => c.User_id)
                .NotEmpty()
                .WithMessage("User_id is required");
                // .MaximumLength(50)
                // .WithMessage("User_id must not exceed 100 characters");
            
            RuleFor(u => u.Is_solved)
                .NotEmpty()
                .WithMessage("Is_solved is required");
                // .MaximumLength(50)
                // .WithMessage("Is_solved must not exceed 100 characters");
            
            RuleFor(u => u.Problem_id)
                .NotEmpty()
                .WithMessage("Problem_id is required");
                // .MaximumLength(50)
                // .WithMessage("Problem_id must not exceed 100 characters");   
        }
        
    }
}