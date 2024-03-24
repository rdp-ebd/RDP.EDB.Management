using RDP.EDB.Management.Application.Abstractions.Mediatr;
using RDP.EDB.Management.Application.Abstractions.Result;
using RDP.EDB.Management.Domain.Entities;

namespace RDP.EDB.Management.Application.UseCases.People.Commands.Create;

public record CreatePersonCommand(
    string FirstName,
    string? MiddleName,
    string Surname
) : ICommandRequest<CommandResult<Person>>;