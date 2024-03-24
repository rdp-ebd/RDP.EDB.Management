using FluentValidation;
using RDP.EDB.Management.Application.Abstractions.Validators;
using RDP.EDB.Management.Application.UseCases.Authentication.Commands.Create;

namespace RDP.EDB.Management.Application.UseCases.People.Commands.Create;

public class CreateAuthenticationCommandValidator 
    : AbstractValidator<CreateAuthenticationCommand>, IApplicationRequestValidator
{
    public CreateAuthenticationCommandValidator()
    {
        RuleFor(x => x.Email).NotEmpty();
        RuleFor(x => x.Password).NotEmpty();
        RuleFor(x => x.Username).NotEmpty();
    }
}
