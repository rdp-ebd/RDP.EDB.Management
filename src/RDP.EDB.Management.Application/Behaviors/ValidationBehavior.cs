using FluentValidation;
using FluentValidation.Results;
using MediatR;
using RDP.EDB.Management.Application.Abstractions.Errors;
using RDP.EDB.Management.Application.Exceptions.Validations;

namespace RDP.EDB.Management.Application.Behaviors;

public sealed class ValidationBehavior<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(
        TRequest request, 
        RequestHandlerDelegate<TResponse> next, 
        CancellationToken cancellationToken
    )
    {
        var context = new ValidationContext<TRequest>(request);
        var validationFailures = await Task.WhenAll(
            _validators.Select(validator => validator.ValidateAsync(context))
        );

        var errors = ValidationBehavior<TRequest, TResponse>.GetValidationErrors(validationFailures);
        if(errors?.Count > 0)
        {
            throw new FluentValidationException(errors);
        }

        return await next();
    }

    private static List<ValidationError> GetValidationErrors(ValidationResult[] validationFailures) =>
        validationFailures.Where(x => !x.IsValid)
            .SelectMany(x => x.Errors)
            .Select(x => new ValidationError(x.PropertyName, x.ErrorMessage))
            .ToList();

}
