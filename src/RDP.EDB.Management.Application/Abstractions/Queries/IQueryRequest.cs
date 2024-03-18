using MediatR;

namespace RDP.EDB.Management.Application.Abstractions.Queries;

public interface IQueryRequest<TResult> : IRequest<TResult>
{
}