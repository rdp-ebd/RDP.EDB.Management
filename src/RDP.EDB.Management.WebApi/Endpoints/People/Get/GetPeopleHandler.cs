using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RDP.EDB.Management.Application.UseCases.People.Queries.Get;

namespace RDP.EDB.Management.WebApi.Endpoints.People.Get;

public class GetPeopleHandler
{
    public static async Task<Ok<IEnumerable<GetPeopleResponse>>> HandleAsync(
        [FromServices] ISender sender,
        [FromServices] IMapper mapper,
        CancellationToken token
    )
    {
        var people = await sender.Send(new GetPeopleQuery(), token);
        var peopleResponse = mapper.Map<IEnumerable<GetPeopleResponse>>(people);

        return TypedResults.Ok(peopleResponse);
    }
}
