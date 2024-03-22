using RDP.EDB.Management.Application.Abstractions.Queries;

namespace RDP.EDB.Management.Application.UseCases.People.Queries.Get;

public class GetPeopleQueryHandler : IQueryHandler<GetPeopleQuery, GetPeopleQueryResult>
{
    public async Task<GetPeopleQueryResult> Handle(
        GetPeopleQuery request,
        CancellationToken cancellationToken
    )
    {
        return new GetPeopleQueryResult([
            new("john", "doe"),
            new("ana", "dane"),
        ]);
    }
}
