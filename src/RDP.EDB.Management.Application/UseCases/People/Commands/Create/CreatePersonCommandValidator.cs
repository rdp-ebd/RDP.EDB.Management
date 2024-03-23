using FluentValidation;

namespace RDP.EDB.Management.Application.UseCases.People.Commands.Create;

public class CreatePersonCommandValidator : AbstractValidator<CreatePersonCommand>
{
    public CreatePersonCommandValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty();
        RuleFor(x => x.Surname).NotEmpty();
    }
}
