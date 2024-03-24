using FluentValidation;
using RDP.EDB.Management.Application.Abstractions.Validators;

namespace RDP.EDB.Management.Application.UseCases.People.Commands.Create;

public class CreatePersonCommandValidator 
    : AbstractValidator<CreatePersonCommand>, IApplicationRequestValidator
{
    public CreatePersonCommandValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty();
        RuleFor(x => x.Surname).NotEmpty();
    }
}
