using RDP.EDB.Management.Application;
using RDP.EDB.Management.Application.Behaviors;

namespace RDP.EDB.Management.WebApi.Extensions;

public static class MediatrExtensions
{
    public static IServiceCollection AddMediatr(this IServiceCollection services)
    {
        services.AddMediatR(cfg => {
            cfg.RegisterServicesFromAssembly(typeof(ApplicationAssembly).Assembly);
            cfg.AddOpenBehavior(typeof(ValidationBehavior<,>));
        });

        return services;
    }
}
