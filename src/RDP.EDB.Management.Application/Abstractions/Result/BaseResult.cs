namespace RDP.EDB.Management.Application.Abstractions.Result;

public abstract class BaseResult<T>
{
    public T? Data { get; }
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public IReadOnlyCollection<string>? FailureDetails { get; }

    protected BaseResult(T? data, bool isSuccess, List<string>? failureDetails = null)
    {
        Data = data;
        IsSuccess = isSuccess;
        FailureDetails = (failureDetails ?? []).AsReadOnly();
    }
}
