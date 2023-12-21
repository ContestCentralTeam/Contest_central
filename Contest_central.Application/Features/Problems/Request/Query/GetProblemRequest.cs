using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Contest_central.Application.DTOs.Problems;

namespace Contest_central.Application.Features.Problems.Request.Query
{
    public class GetProblemRequest: IRequest<ProblemDto>
    {
        public Guid ProblemId { get; set; }
        
    }
}