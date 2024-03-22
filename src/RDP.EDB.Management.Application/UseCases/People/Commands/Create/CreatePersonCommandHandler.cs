using RDP.EDB.Management.Application.Abstractions.Commands;

namespace RDP.EDB.Management.Application.UseCases.People.Commands.Create;

public class CreatePersonCommandHandler : ICommandHandler<CreatePersonCommand, CreatePersonCommandResult>
{
    public async Task<CreatePersonCommandResult> Handle(
        CreatePersonCommand request, 
        CancellationToken cancellationToken
    )
    {
        return new(
            new(request.FirstName, request.Surname, request.MiddleName)
        );
    }
}
