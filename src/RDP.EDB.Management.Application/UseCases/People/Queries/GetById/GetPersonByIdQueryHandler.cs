using RDP.EDB.Management.Application.Abstractions.Queries;

namespace RDP.EDB.Management.Application.UseCases.People.Queries.GetById;

public class GetPersonByIdQueryHandler : IQueryHandler<GetPersonByIdQuery, GetPersonByIdQueryResult>
{
    public async Task<GetPersonByIdQueryResult> Handle(
        GetPersonByIdQuery request, 
        CancellationToken cancellationToken
    )
    {
        if (request.Id == 1)
            return new(new("John", "Doe"));

        return new(null);
    }
}
