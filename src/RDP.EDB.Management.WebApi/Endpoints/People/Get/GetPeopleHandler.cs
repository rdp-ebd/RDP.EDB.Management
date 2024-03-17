using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RDP.EDB.Management.Application.UseCases.People.Queries.Get;

namespace RDP.EDB.Management.WebApi.Endpoints.People.Get;

public class GetPeopleHandler
{
    public static async Task<Ok<IEnumerable<GetPeopleResponse>>> HandleAsync(
        CancellationToken token,
        [FromServices] ISender sender
    )
    {
        var response = await sender.Send(new GetPeopleQuery());

        // TODO: refatorar para mapper
        return TypedResults.Ok(response.Select(x => 
            new GetPeopleResponse(x.FirstName, x.Surname)
        ));
    }
}
