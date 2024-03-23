using FluentValidation;
using RDP.EDB.Management.Application.UseCases.People.Commands.Create;

namespace RDP.EDB.Management.WebApi.Extensions;

public static class FluentValidationsExtensions
{
    public static IServiceCollection AddFluentValidation(this IServiceCollection services)
    {
        services.AddScoped<IValidator<CreatePersonCommand>, CreatePersonCommandValidator>();

        return services;
    }
}
