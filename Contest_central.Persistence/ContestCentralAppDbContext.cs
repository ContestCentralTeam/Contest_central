using Contest_central.Domain.Entities;
using Contest_central.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Persistence;
public class ContestCentralAppDbContext : DbContext
{
    public ContestCentralAppDbContext(DbContextOptions<ContestCentralAppDbContext> options ) : base( options )
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContestCentralAppDbContext).Assembly);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries<BaseEntity>())
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedDate = DateTime.Now;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }

    public DbSet<Contest> Contests { get; set; }
    public DbSet<Log> Logs { get; set; }
    public DbSet<ProblemLog> ProblemLogs { get; set; }
    public DbSet<Problem> Problems { get; set; }
    public DbSet<User> Users { get; set; }
    
}
