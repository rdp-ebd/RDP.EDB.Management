using RDP.EDB.Management.Domain.Repositories;
using RDP.EDB.Management.Infra.Repositories;

namespace RDP.EDB.Management.WebApi.Extensions;

public static class RepositoryExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IPersonRepository, PersonRepository>();

        return services;
    }
}
