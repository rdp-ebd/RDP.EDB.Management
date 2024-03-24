using RDP.EDB.Management.Application.Abstractions.Mediatr;
using RDP.EDB.Management.Application.Abstractions.Result;
using RDP.EDB.Management.Domain.Entities;

namespace RDP.EDB.Management.Application.UseCases.People.Commands.Create;

public class CreatePersonCommandHandler : ICommandRequestHandler<CreatePersonCommand, CommandResult<Person>>
{
    public async Task<CommandResult<Person>> Handle(
        CreatePersonCommand request,
        CancellationToken cancellationToken
    )
    {
        return CommandResult<Person>.Success(
            new(request.FirstName, request.Surname, request.MiddleName)
        );
    }
}
