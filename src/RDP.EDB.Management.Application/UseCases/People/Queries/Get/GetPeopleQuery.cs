using RDP.EDB.Management.Application.Abstractions.Queries;

namespace RDP.EDB.Management.Application.UseCases.People.Queries.Get;

public record GetPeopleQuery() : IQueryRequest<GetPeopleQueryResult>;