namespace RDP.EDB.Management.Application.Abstractions.Result;

public abstract class BaseResult<T> : BaseResult
{
    public T? Data { get; }

    protected BaseResult(
        T? data,
        bool isSuccess,
        List<string>? failureDetails = null
    ) : base(isSuccess, failureDetails)
    {
        Data = data;
    }
}
