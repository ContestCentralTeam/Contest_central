using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contest_central.Application.Persistence.Contracts;
using FluentValidation;

namespace Contest_central.Application.DTOs.ProblemLogs.Validator
{
    public class CreateProblemLogValidator: AbstractValidator<CreateProblemLogDto>
    {
        private readonly IProblemLogRepository _problemLogRepository;

        public CreateProblemLogValidator(IProblemLogRepository problemLogRepository)
        {
            _problemLogRepository = problemLogRepository;
            Include(new IProblemLogValidator(_problemLogRepository));
        }
    }
}
