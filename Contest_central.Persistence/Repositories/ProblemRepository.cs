using Contest_central.Application.Persistence.Contracts;
using Contest_central.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Persistence.Repositories;
public class ProblemRepository : GenericRepository<Problem>, IProblemRepository
{
    private readonly ContestCentralAppDbContext _contestCentralAppDbContext1;
    public ProblemRepository(ContestCentralAppDbContext contestCentralAppDbContext) : base(contestCentralAppDbContext)
    {
        _contestCentralAppDbContext1 = contestCentralAppDbContext;
    }
}
