using RDP.EDB.Management.Application.Abstractions.Mediatr;
using RDP.EDB.Management.Application.Abstractions.Result;
using RDP.EDB.Management.Domain.Entities;
using RDP.EDB.Management.Domain.Repositories;

namespace RDP.EDB.Management.Application.UseCases.People.Queries.Get;

public class GetPeopleQueryHandler : IQueryRequestHandler<GetPeopleQuery, List<Person>>
{
    private readonly IPersonRepository _personRepository;

    public GetPeopleQueryHandler(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<QueryResult<List<Person>>> Handle(
        GetPeopleQuery request,
        CancellationToken cancellationToken
    )
    {
        var people = await _personRepository.GetAllAsync();
        return QueryResult<List<Person>>.Success(people);
    }
}
