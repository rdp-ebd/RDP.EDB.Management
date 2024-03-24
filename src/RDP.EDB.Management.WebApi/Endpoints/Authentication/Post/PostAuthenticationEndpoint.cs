using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RDP.EDB.Management.Application.UseCases.Authentication.Commands.Create;

namespace RDP.EDB.Management.WebApi.Endpoints.Authentication.Post;

public class PostAuthenticationEndpoint
{
    public static async Task<Created> HandleAsync(
        [FromBody] CreateAuthenticationCommand command,
        [FromServices] ISender sender,
        CancellationToken cancellationToken
    )
    {
        await sender.Send(command, cancellationToken);
        return TypedResults.Created();
    }
}
