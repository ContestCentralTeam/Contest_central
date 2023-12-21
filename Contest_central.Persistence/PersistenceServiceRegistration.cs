using Contest_central.Application.Persistence.Contracts;
using Contest_central.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Persistence;
public static class PersistenceServiceRegistration
{
    public static IServiceCollection ConfigurePersitenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ContestCentralAppDbContext>(opt => opt.UseNpgsql(configuration.GetConnectionString("SocialMediaAppConnection")));
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IContestRepository, ContestRepository>();
        services.AddScoped<ILogRepository, LogRepository>();
        services.AddScoped<IProblemLogRepository, ProblemLogRepository>();
        services.AddScoped<IProblemRepository, ProblemRepository>();

        return services;
    }
}
