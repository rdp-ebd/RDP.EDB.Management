using MediatR;
using RDP.EDB.Management.Domain.Entities;

namespace RDP.EDB.Management.Application.UseCases.People.Queries.GetById;

public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, Person?>
{
    public async Task<Person?> Handle(
        GetPersonByIdQuery request, 
        CancellationToken cancellationToken
    )
    {
        if (request.Id == 1)
            return new("John", "Doe");

        return null;
    }
}
