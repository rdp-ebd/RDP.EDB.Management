using MediatR;

namespace RDP.EDB.Management.Application.Abstractions.Mediatr;

public interface IQueryRequestHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>;