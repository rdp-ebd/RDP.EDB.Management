using MediatR;
using RDP.EDB.Management.Domain.Entities;

namespace RDP.EDB.Management.Application.UseCases.People.Queries.Get;

public record GetPeopleQuery() : IRequest<IEnumerable<Person>>;
