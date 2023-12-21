using AutoMapper;
using Contest_central.Application.DTOs.Contests.Validator;
using Contest_central.Application.Features.Contests.Request.Command;
using Contest_central.Application.Persistence.Contracts;
using Contest_central.Application.Responses;
using Contest_central.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Application.Features.Contests.Handler.Command
{
    public class CreateContestCommandHandler : IRequestHandler<CreateContestCommand, BaseResponseClass>
    {
        private readonly IContestRepository _contestrepository ;
        private readonly IMapper _mapper ;
        public CreateContestCommandHandler(IContestRepository contestrepository, IMapper mapper)
        {
            this._contestrepository = contestrepository;
            this._mapper = mapper;
        }
        public async Task<BaseResponseClass> Handle(CreateContestCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateContestValidator(_contestrepository);
            var validationResult = await validator.ValidateAsync(request.CreateContestDto, cancellationToken);
            var response = new BaseResponseClass();
            if (validationResult.IsValid)
            {
                var constest = _mapper.Map<Contest>(request.CreateContestDto);
                var result = await _contestrepository.Add(constest);
                response.Message = "Contest created succesfully";
                response.Success = true;
                response.Error = new List<string>();
            }
            else
            {
                
                response.Success= false;
                response.Message = "Contest creation failed";
                response.Error = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }

            return response;
        }
    }
}
