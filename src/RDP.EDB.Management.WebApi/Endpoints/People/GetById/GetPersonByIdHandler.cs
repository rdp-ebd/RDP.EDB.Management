using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RDP.EDB.Management.Application.UseCases.People.Queries.GetById;

namespace RDP.EDB.Management.WebApi.Endpoints.People.GetById;

public class GetPersonByIdHandler
{
    public static async Task<Results<Ok<GetPersonByIdResponse>, NotFound>> HandleAsync(
        int id,
        [FromServices] ISender sender,
        [FromServices] IMapper mapper,
        CancellationToken cancellationToken
    )
    {
        var result = await sender.Send(new GetPersonByIdQuery(id), cancellationToken);
        if (result?.Data is null)
            return TypedResults.NotFound();

        return TypedResults.Ok(mapper.Map<GetPersonByIdResponse>(result?.Data));
    }
}
