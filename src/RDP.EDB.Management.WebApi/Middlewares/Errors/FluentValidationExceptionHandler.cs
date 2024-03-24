using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RDP.EDB.Management.Application.Exceptions.Validations;

namespace RDP.EDB.Management.WebApi.Middlewares.Errors;

public sealed class FluentValidationExceptionHandler(ILogger<FluentValidationExceptionHandler> logger) : IExceptionHandler
{
    private readonly ILogger<FluentValidationExceptionHandler> _logger = logger;

    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken
    )
    {
        if (exception is not FluentValidationException fluentValidationException)
            return false;

        _logger.LogError(exception, "A validation error just happened! Catch it: {Message}", exception.Message);

        var problemDetails = new ProblemDetails()
        {
            Status = StatusCodes.Status406NotAcceptable,
            Type = "https://tools.ietf.org/html/rfc7231#section-6.5.1",
            Detail = "One or more validation errors occurred"
        };

        problemDetails.Extensions["errors"] = fluentValidationException.Errors;

        httpContext.Response.StatusCode = StatusCodes.Status406NotAcceptable;
        await httpContext.Response.WriteAsJsonAsync(
            problemDetails,
            cancellationToken
        );

        return true;
    }
}
