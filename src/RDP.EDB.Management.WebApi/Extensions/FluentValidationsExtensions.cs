using FluentValidation;
using RDP.EDB.Management.Application;
using RDP.EDB.Management.Application.Abstractions.Validators;

namespace RDP.EDB.Management.WebApi.Extensions;

public static class FluentValidationsExtensions
{
    public static IServiceCollection AddFluentValidation(this IServiceCollection services)
    {
        //services.AddScoped<IValidator<CreatePersonCommand>, CreatePersonCommandValidator>();

        var validatorTypes = typeof(ApplicationAssembly).Assembly
            .GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && typeof(IApplicationRequestValidator).IsAssignableFrom(t));

        foreach (var validatorType in validatorTypes)
        {
            var validatorInterface = validatorType.GetInterfaces().FirstOrDefault(i => 
                i.IsGenericType 
                && i.GetGenericTypeDefinition() == typeof(IValidator<>)
            );

            if (validatorInterface != null)
            {
                services.AddScoped(validatorInterface, validatorType);
            }
        }

        return services;
    }
}
