using MediatR;
using RDP.EDB.Management.Application.Abstractions.Result;

namespace RDP.EDB.Management.Application.Abstractions.Mediatr;

public interface ICommandRequest
    : IRequest<CommandResult>;


public interface ICommandRequest<TResponse> 
    : IRequest<CommandResult<TResponse>>;