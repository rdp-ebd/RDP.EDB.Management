namespace RDP.EDB.Management.Application.Abstractions.Result;

public abstract class BaseListResult<T>
{
    public IEnumerable<T> Data { get; }

    protected BaseListResult(IEnumerable<T> data)
    {
        Data = data;
    }
}
