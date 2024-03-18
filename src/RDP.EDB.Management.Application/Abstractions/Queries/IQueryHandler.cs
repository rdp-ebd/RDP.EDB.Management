using MediatR;

namespace RDP.EDB.Management.Application.Abstractions.Queries;

public interface IQueryHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>;