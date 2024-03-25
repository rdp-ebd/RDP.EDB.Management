namespace RDP.EDB.Management.Application.Abstractions.Result;

public class QueryResult<T> : BaseResult<T>
{
    protected QueryResult(
        T? data,
        bool isSuccess,
        List<string>? failureDetails = null
    ) : base(data, isSuccess, failureDetails)
    {
    }

    public static QueryResult<T> Success(T? data)
    {
        return new(data, true);
    }

    public static QueryResult<T> Failure(List<string> failureDetails)
    {
        return new(default, false, failureDetails);
    }
}
