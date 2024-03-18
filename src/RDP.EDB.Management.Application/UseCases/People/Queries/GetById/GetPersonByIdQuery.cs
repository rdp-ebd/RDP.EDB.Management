using RDP.EDB.Management.Application.Abstractions.Queries;

namespace RDP.EDB.Management.Application.UseCases.People.Queries.GetById;

public record GetPersonByIdQuery(int Id): IQueryRequest<GetPersonByIdQueryResult>;