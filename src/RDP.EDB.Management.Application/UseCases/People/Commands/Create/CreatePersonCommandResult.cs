using RDP.EDB.Management.Application.Abstractions.Result;
using RDP.EDB.Management.Domain.Entities;

namespace RDP.EDB.Management.Application.UseCases.People.Commands.Create;

public class CreatePersonCommandResult(Person? data) : BaseResult<Person>(data)
{
}