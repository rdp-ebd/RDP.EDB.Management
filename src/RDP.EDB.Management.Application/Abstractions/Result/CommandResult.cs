namespace RDP.EDB.Management.Application.Abstractions.Result;

public class CommandResult : BaseResult
{
    private CommandResult(
        bool isSuccess,
        List<string>? failureDetails = null
    ) : base(isSuccess, failureDetails)
    {
    }

    public static CommandResult Success()
    {
        return new(true);
    }

    public static CommandResult Failure(List<string> failureDetails)
    {
        return new(false, failureDetails);
    }
}