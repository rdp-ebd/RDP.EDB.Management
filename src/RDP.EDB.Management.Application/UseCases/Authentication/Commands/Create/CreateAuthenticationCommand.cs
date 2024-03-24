using RDP.EDB.Management.Application.Abstractions.Mediatr;

namespace RDP.EDB.Management.Application.UseCases.Authentication.Commands.Create;

public record CreateAuthenticationCommand(string Email, string Username, string Password) : ICommandRequest;