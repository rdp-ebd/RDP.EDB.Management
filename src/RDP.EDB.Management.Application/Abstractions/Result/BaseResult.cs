namespace RDP.EDB.Management.Application.Abstractions.Result;

public abstract class BaseResult
{
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public IReadOnlyCollection<string>? FailureDetails { get; }

    protected BaseResult(bool isSuccess, List<string>? failureDetails = null)
    {
        IsSuccess = isSuccess;
        FailureDetails = (failureDetails ?? []).AsReadOnly();
    }
}
