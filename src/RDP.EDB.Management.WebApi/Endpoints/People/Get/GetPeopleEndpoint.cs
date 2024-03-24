using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RDP.EDB.Management.Application.Abstractions.Result;
using RDP.EDB.Management.Application.UseCases.People.Queries.Get;
using RDP.EDB.Management.Domain.Entities;

namespace RDP.EDB.Management.WebApi.Endpoints.People.Get;

public class GetPeopleEndpoint
{
    public static async Task<Ok<QueryResult<List<Person>>>> HandleAsync(
        [FromServices] ISender sender,
        CancellationToken token
    )
    {
        var result = await sender.Send(new GetPeopleQuery(), token);
        return TypedResults.Ok(result);
    }
}
