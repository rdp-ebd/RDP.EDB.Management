using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RDP.EDB.Management.Application.UseCases.People.Commands.Create;

namespace RDP.EDB.Management.WebApi.Endpoints.People.Post;

public class PostPersonEndpoint
{
    public static async Task<Created> HandleAsync(
        [FromBody] CreatePersonCommand command,
        [FromServices] ISender sender,
        CancellationToken cancellationToken
    )
    {
        await sender.Send(command, cancellationToken);
        return TypedResults.Created();
    }
}
