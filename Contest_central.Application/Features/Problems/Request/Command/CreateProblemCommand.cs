using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contest_central.Application.Responses;
using Contest_central.Application.DTOs.Problems;
using MediatR;

namespace Contest_central.Application.Features.Problems.Request.Command
{
    public class CreateProblemCommand: IRequest<BaseResponseClass>
    {
        public CreateProblemDto? CreateProblemDto { get; set; }
        
    }
}