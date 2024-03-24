using RDP.EDB.Management.Application.Abstractions.Mediatr;
using RDP.EDB.Management.Application.Abstractions.Result;
using RDP.EDB.Management.Domain.Entities;

namespace RDP.EDB.Management.Application.UseCases.People.Queries.Get;

public record GetPeopleQuery() : IQueryRequest<QueryResult<List<Person>>>;