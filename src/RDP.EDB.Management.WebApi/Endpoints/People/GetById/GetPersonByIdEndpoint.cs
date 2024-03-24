using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RDP.EDB.Management.Application.Abstractions.Result;
using RDP.EDB.Management.Application.UseCases.People.Queries.GetById;
using RDP.EDB.Management.Domain.Entities;

namespace RDP.EDB.Management.WebApi.Endpoints.People.GetById;

public class GetPersonByIdEndpoint
{
    public static async Task<Results<Ok<QueryResult<Person>>, NotFound>> HandleAsync(
        int id,
        [FromServices] ISender sender,
        [FromServices] IMapper mapper,
        [FromServices] ILogger<GetPersonByIdEndpoint> logger,
        CancellationToken cancellationToken
    )
    {
        var result = await sender.Send(new GetPersonByIdQuery(id), cancellationToken);
        if (result.Data is null)
        {
            logger.LogInformation("{endpoint} with id {id} has missed?", nameof(GetPersonByIdEndpoint), id);
            return TypedResults.NotFound();
        }

        return TypedResults.Ok(result);
    }
}
