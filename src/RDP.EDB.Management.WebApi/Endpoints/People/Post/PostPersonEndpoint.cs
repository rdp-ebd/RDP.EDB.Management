using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RDP.EDB.Management.Application.Abstractions.Result;
using RDP.EDB.Management.Application.UseCases.People.Commands.Create;

namespace RDP.EDB.Management.WebApi.Endpoints.People.Post;

public class PostPersonEndpoint
{
    public static async Task<Results<Ok<CommandResult<Guid?>>, BadRequest>> HandleAsync(
        [FromBody] CreatePersonCommand command,
        [FromServices] ISender sender,
        [FromServices] ILogger<PostPersonEndpoint> logger,
        CancellationToken cancellationToken
    )
    {
        var result = await sender.Send(command, cancellationToken);

        if (result.IsSuccess && result.Data is not null)
        {
            logger.LogInformation("This was created at {endpoint}: {@person}", nameof(PostPersonEndpoint), result.Data);
            return TypedResults.Ok(
                CommandResult<Guid?>.Success(result.Data.Id)
            );
        }

        return TypedResults.BadRequest();
    }
}
