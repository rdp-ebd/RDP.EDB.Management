namespace RDP.EDB.Management.Application.Abstractions.Errors;

public record ValidationError(string PropertyName, string ErrorMessage);
