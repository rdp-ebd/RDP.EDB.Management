using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using RDP.EDB.Management.Application.Abstractions.Commands;
using RDP.EDB.Management.Application.Identification;

namespace RDP.EDB.Management.Application.UseCases.Authentication.Commands.Create;

public class CreateAuthenticationCommandHandler : ICommandHandler<CreateAuthenticationCommand>
{
    private readonly ILogger<CreateAuthenticationCommandHandler> _logger;
    private readonly UserManager<EbdUser> _userManager;

    public CreateAuthenticationCommandHandler(
        ILogger<CreateAuthenticationCommandHandler> logger, 
        UserManager<EbdUser> userManager
    )
    {
        _logger = logger;
        _userManager = userManager;
    }

    public async Task Handle(
        CreateAuthenticationCommand command, 
        CancellationToken cancellationToken)
    {
        var newUser = new EbdUser() 
        { 
            UserName = command.Username,
            Email = command.Email,
        };

        var result = await _userManager.CreateAsync(newUser, command.Password);
        if(result.Succeeded )
        {
            return;
        }

        _logger.LogError("Failed to create user with json: {@command} \nErrors: {@errors}",
            command,
            result.Errors
        );

        throw new Exception();
    }
}
