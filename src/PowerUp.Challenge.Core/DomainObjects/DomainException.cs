namespace PowerUp.Challenge.Core.DomainObjects;

public sealed class DomainException(string message) : Exception(message)
{
}
