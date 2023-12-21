using Contest_central.Application.DTOs.Contests;
using Contest_central.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Application.Features.Contests.Request.Query
{
    public class GetContestRequest : IRequest<ContestDto>
    {
        public Guid ContestId { get; set; }
    }
}
