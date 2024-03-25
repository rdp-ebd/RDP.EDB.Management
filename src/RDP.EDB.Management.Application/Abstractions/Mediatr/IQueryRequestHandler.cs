using MediatR;
using RDP.EDB.Management.Application.Abstractions.Result;

namespace RDP.EDB.Management.Application.Abstractions.Mediatr;

public interface IQueryRequestHandler<TRequest, TResponse> 
    : IRequestHandler<TRequest, QueryResult<TResponse>>
    where TRequest : IQueryRequest<TResponse>;