using Microsoft.AspNetCore.Http.HttpResults;

namespace RDP.EDB.Management.WebApi.Endpoints.People.GetById;

public class GetPeopleByIdHandler
{
    public static async Task<Results<Ok<GetPeopleByIdResponse>, NotFound>> HandleAsync(
        int id,
        CancellationToken cancellationToken
    )
    {
        if(id == 1)
            return TypedResults.Ok(new GetPeopleByIdResponse("john", "doe"));

        return TypedResults.NotFound();
    }
}
