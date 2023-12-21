using AutoMapper;
using Contest_central.Application.DTOs.Contests;
using Contest_central.Application.Features.Contests.Request.Query;
using Contest_central.Application.Persistence.Contracts;
using Contest_central.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Application.Features.Contests.Handler.Query
{
    public class GetContestRequestHandler : IRequestHandler<GetContestRequest, ContestDto>
    {
        private readonly IContestRepository _contestRepository;
        private readonly IMapper _mapper;

        public GetContestRequestHandler(IContestRepository contestRepository, IMapper mapper)
        {
            this._contestRepository = contestRepository;
            this._mapper = mapper;
        }

        public async Task<ContestDto> Handle(GetContestRequest request, CancellationToken cancellationToken)
        {
            var contest = await _contestRepository.GetById(request.ContestId);
            return _mapper.Map<ContestDto>(contest);
        }
    }
}
