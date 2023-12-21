using Contest_central.Application.Persistence.Contracts;
using Contest_central.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Persistence.Repositories;
public class UserRepository : GenericRepository<User>, IUserRepository
{
    private readonly ContestCentralAppDbContext _context;
    public UserRepository(ContestCentralAppDbContext contestCentralAppDbContext) : base(contestCentralAppDbContext)
    {
        _context = contestCentralAppDbContext;
    }
}
