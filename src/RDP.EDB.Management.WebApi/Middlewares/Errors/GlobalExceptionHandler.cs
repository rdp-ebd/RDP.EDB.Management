using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace RDP.EDB.Management.WebApi.Middlewares.Errors;

public sealed class GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger) : IExceptionHandler
{
    private readonly ILogger<GlobalExceptionHandler> _logger = logger;

    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext, 
        Exception exception, 
        CancellationToken cancellationToken
    )
    {
        _logger.LogError(exception, "A global error has spawned! Catch it: {Message}", exception.Message);

        httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        await httpContext.Response.WriteAsJsonAsync(
            new ProblemDetails()
            {
                Status = StatusCodes.Status500InternalServerError,
                Title = "Server problems!",
                Detail = "Server has failed catastrophically, please call BIG SANDRO!"
            },
            cancellationToken
        );

        return true;
    }
}
