using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contest_central.Application.DTOs.Problems.Validator;
using Contest_central.Application.Features.Problems.Request.Command;
using Contest_central.Application.Persistence.Contracts;
using Contest_central.Application.Responses;
using MediatR;

namespace Contest_central.Application.Features.Problems.Handler.Command
{
    public class CreateProblemCommandHandler: IRequestHandler<CreateProblemCommand, BaseResponseClass>
    {
        private readonly IProblemRepository _problemRepository;
        public CreateProblemCommandHandler(IProblemRepository problemRepository)
        {
            this._problemRepository = problemRepository;
        }
        public async Task<BaseResponseClass> Handle(CreateProblemCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateProblemValidator(_problemRepository);
            var validationResult = await validator.ValidateAsync(request.CreateProblemDto, cancellationToken);
            var response = new BaseResponseClass();
            if (validationResult.IsValid)
            {
                response.Message = "Problem created succesfully";
                response.Success = true;
                response.Error = new List<string>();
            }
            else
            {
                response.Success= false;
                response.Message = "Problem creation failed";
                response.Error = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }

            return response;
        }   
    }
}