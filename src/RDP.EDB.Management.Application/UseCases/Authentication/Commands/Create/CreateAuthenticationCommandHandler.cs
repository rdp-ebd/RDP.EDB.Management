using Microsoft.Extensions.Logging;
using RDP.EDB.Management.Application.Abstractions.Commands;

namespace RDP.EDB.Management.Application.UseCases.Authentication.Commands.Create;

public class CreateAuthenticationCommandHandler : ICommandHandler<CreateAuthenticationCommand>
{
    private readonly ILogger<CreateAuthenticationCommandHandler> _logger;

    public CreateAuthenticationCommandHandler(ILogger<CreateAuthenticationCommandHandler> logger)
    {
        _logger = logger;
    }

    public async Task Handle(
        CreateAuthenticationCommand request, 
        CancellationToken cancellationToken)
    {
        _logger.LogInformation("here we are");
        await Task.CompletedTask;
    }
}
