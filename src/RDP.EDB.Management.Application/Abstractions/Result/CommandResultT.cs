namespace RDP.EDB.Management.Application.Abstractions.Result;

public class CommandResult<T> : BaseResult<T>
{
    private CommandResult(
        T? data,
        bool isSuccess,
        List<string>? failureDetails = null
    ) : base(data, isSuccess, failureDetails)
    {
    }

    public static CommandResult<T> Success(T? data)
    {
        return new(data, true);
    }

    public static CommandResult<T> Failure(List<string> failureDetails)
    {
        return new(default, false, failureDetails);
    }
}
