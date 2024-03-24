using MediatR;

namespace RDP.EDB.Management.Application.Abstractions.Mediatr;

public interface ICommandRequest<out TResponse> : IRequest<TResponse>;
public interface ICommandRequest : IRequest;
