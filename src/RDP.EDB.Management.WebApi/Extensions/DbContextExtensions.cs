using Microsoft.EntityFrameworkCore;
using RDP.EDB.Management.Infra;
using RDP.EDB.Management.Infra.Contexts;

namespace RDP.EDB.Management.WebApi.Extensions;

public static class DbContextExtensions
{
    public static IServiceCollection AddEntityFrameworkDbContext(
        this IServiceCollection services, 
        ConfigurationManager configuration
    )
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"), sqlConf =>
            {
                sqlConf.MigrationsAssembly(typeof(InfraAssembly).Assembly.GetName().Name);
            });
        });

        return services;
    }
}
