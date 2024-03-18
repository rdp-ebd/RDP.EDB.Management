namespace RDP.EDB.Management.Application.Abstractions.Result;

public abstract class BaseListResult<T>
{
    public IEnumerable<T> Result { get; }

    protected BaseListResult(IEnumerable<T> result)
    {
        Result = result;
    }
}
