using RDP.EDB.Management.WebApi.Middlewares.Errors;

namespace RDP.EDB.Management.WebApi.Extensions;

public static class ExceptionHandlersExtensions
{
    public static IServiceCollection AddExceptionHandlers(this IServiceCollection services)
    {
        services.AddExceptionHandler<FluentValidationExceptionHandler>();
        services.AddExceptionHandler<GlobalExceptionHandler>();

        //

        services.AddProblemDetails();

        //

        return services;
    }
}
