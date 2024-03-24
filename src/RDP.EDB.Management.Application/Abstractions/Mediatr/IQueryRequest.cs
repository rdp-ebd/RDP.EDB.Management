using MediatR;

namespace RDP.EDB.Management.Application.Abstractions.Mediatr;

public interface IQueryRequest<out TResult> : IRequest<TResult>;
