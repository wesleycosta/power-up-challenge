using FluentValidation.Results;

namespace PowerUp.Challenge.Core.Messages;

public sealed class CommandHandlerResult
{
    public ValidationResult ValidationResult { get; init; }
    public object Response { get; init; }

    public bool IsValid =>
        ValidationResult?.Errors?.Count == 0;
}
