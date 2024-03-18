using MediatR;

namespace RDP.EDB.Management.Application.UseCases.People.Queries.Get;

public class GetPeopleQueryHandler : IRequestHandler<GetPeopleQuery, GetPeopleQueryResult>
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
