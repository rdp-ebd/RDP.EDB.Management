using MediatR;

namespace RDP.EDB.Management.Application.UseCases.People.Queries.GetById;

public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, GetPersonByIdQueryResult>
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
