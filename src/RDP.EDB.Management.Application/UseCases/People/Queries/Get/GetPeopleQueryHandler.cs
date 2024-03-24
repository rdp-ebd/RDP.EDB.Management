using RDP.EDB.Management.Application.Abstractions.Mediatr;
using RDP.EDB.Management.Application.Abstractions.Result;
using RDP.EDB.Management.Domain.Entities;

namespace RDP.EDB.Management.Application.UseCases.People.Queries.Get;

public class GetPeopleQueryHandler : IQueryRequestHandler<GetPeopleQuery, QueryResult<List<Person>>>
{
    public async Task<QueryResult<List<Person>>> Handle(
        GetPeopleQuery request,
        CancellationToken cancellationToken
    )
    {
        return QueryResult<List<Person>>.Success([
            new("john", "doe"),
            new("ana", "dane"),
        ]);
    }
}
