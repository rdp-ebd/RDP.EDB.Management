using MediatR;
using RDP.EDB.Management.Application.Abstractions.Result;

namespace RDP.EDB.Management.Application.Abstractions.Mediatr;

public interface ICommandRequestHandler<TRequest>
    : IRequestHandler<TRequest, CommandResult>
    where TRequest : ICommandRequest;

public interface ICommandRequestHandler<TRequest, TResponse> 
    : IRequestHandler<TRequest, CommandResult<TResponse>>
    where TRequest : ICommandRequest<TResponse>;