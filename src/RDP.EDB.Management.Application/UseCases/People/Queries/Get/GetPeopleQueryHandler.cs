using MediatR;
using RDP.EDB.Management.Domain.Entities;

namespace RDP.EDB.Management.Application.UseCases.People.Queries.Get;

public class GetPeopleQueryHandler : IRequestHandler<GetPeopleQuery, IEnumerable<Person>>
{
    public async Task<IEnumerable<Person>> Handle(
        GetPeopleQuery request, 
        CancellationToken cancellationToken)
    {
        return
        [
            new("Diego", "Doná"),
            new("Sandro", "Junior", "Ribeiro")
        ];
    }
}
