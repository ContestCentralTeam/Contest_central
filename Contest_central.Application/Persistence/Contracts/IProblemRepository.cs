using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contest_central.Domain.Entities;

namespace Contest_central.Application.Persistence.Contracts
{
    public interface IProblemRepository: IGenericRepository<Problem>
    {   
    }
}