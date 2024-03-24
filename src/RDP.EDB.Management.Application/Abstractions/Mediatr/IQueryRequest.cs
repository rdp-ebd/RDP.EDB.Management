using MediatR;
using RDP.EDB.Management.Application.Abstractions.Result;

namespace RDP.EDB.Management.Application.Abstractions.Mediatr;

public interface IQueryRequest<TResponse> 
    : IRequest<QueryResult<TResponse>>;
