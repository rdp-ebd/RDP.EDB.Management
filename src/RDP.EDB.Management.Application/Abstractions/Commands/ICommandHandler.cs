using MediatR;

namespace RDP.EDB.Management.Application.Abstractions.Commands;

public interface ICommandHandler<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>;