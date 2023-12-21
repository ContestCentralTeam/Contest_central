using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contest_central.Application.DTOs.Problems;
using Contest_central.Application.Features.Problems.Request.Query;
using Contest_central.Application.Persistence.Contracts;
using MediatR;

namespace Contest_central.Application.Features.Problems.Handler.Query
{
    public class GetProblemRequestHandler: IRequestHandler<GetProblemRequest, ProblemDto>
    {
        private readonly IProblemRepository _problemRepository;
        private readonly IMapper _mapper;

        public GetProblemRequestHandler(IProblemRepository problemRepository, IMapper mapper)
        {
            this._problemRepository = problemRepository;
            this._mapper = mapper;
        }

        public async Task<ProblemDto> Handle(GetProblemRequest request, CancellationToken cancellationToken)
        {
            var problem = await _problemRepository.GetById(request.ProblemId);
            return _mapper.Map<ProblemDto>(problem);
        }
        
    }
}