using Contest_central.Application.DTOs.Contest;
using Contest_central.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Application.Features.Contests.Request.Command;
public class CreateContestCommand : IRequest<BaseResponseClass>
{
    public CreateContestDto? CreateContestDto { get; set; }
}
