using RDP.EDB.Management.Application.Abstractions.Mediatr;
using RDP.EDB.Management.Domain.Entities;

namespace RDP.EDB.Management.Application.UseCases.People.Queries.GetById;

public record GetPersonByIdQuery(int Id): IQueryRequest<Person>;