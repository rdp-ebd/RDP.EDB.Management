namespace RDP.EDB.Management.Application.Abstractions.Result;

public abstract class BaseResult<T>
{
    public T? Data { get; }

    protected BaseResult(T? data)
    {
        Data = data;
    }
}
