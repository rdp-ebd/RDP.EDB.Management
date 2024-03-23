using RDP.EDB.Management.Application.Abstractions.Errors;
using System.Text;

namespace RDP.EDB.Management.Application.Exceptions.Validations;

public sealed class FluentValidationException(List<ValidationError> errors) : Exception(GetMessage(errors))
{
    private readonly List<ValidationError> _errors = errors;

    public IReadOnlyCollection<ValidationError> Errors => _errors.AsReadOnly();

    private static string GetMessage(List<ValidationError> validationErrors)
    {
        StringBuilder sb = new();
        foreach (var error in validationErrors) 
        { 
            sb.AppendFormat("Property: {0} Message: {1}", error.PropertyName, error.ErrorMessage);
            sb.AppendLine();
        }

        return sb.ToString();
    }
}
