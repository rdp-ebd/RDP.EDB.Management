using MediatR;

namespace RDP.EDB.Management.Application.Abstractions.Commands;

public interface ICommandRequest<out TResponse> : IRequest<TResponse>;
public interface ICommandRequest : IRequest;
