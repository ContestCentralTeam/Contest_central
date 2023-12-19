using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contest_central.Application.Persistence.Contracts;
using FluentValidation;

namespace Contest_central.Application.DTOs.Problems.Validator
{
    public class CreateProblemValidator: AbstractValidator<CreateProblemDto>
    {
        private readonly IProblemRepository _problemRepository;

        public CreateProblemValidator(IProblemRepository problemRepository)
        {
            _problemRepository = problemRepository;
            Include(new IProblemValidator(_problemRepository));
        }
    }
}
