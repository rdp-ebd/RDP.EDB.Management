using RDP.EDB.Management.Application.Abstractions.Mediatr;
using RDP.EDB.Management.Application.Abstractions.Result;
using RDP.EDB.Management.Domain.Entities;

namespace RDP.EDB.Management.Application.UseCases.People.Queries.GetById;

public class GetPersonByIdQueryHandler : IQueryRequestHandler<GetPersonByIdQuery, QueryResult<Person>>
{
    public async Task<QueryResult<Person>> Handle(
        GetPersonByIdQuery request,
        CancellationToken cancellationToken
    )
    {
        if(request.Id == 1)
            return QueryResult<Person>.Success(new("john", "doe"));

        return QueryResult<Person>.Failure([$"Id: {request.Id} not found"]);
    }
}
