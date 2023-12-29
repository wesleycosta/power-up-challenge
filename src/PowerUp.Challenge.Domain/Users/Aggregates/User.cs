using PowerUp.Challenge.Core.DomainObjects;

namespace PowerUp.Challenge.Domain.Users.Aggregates;

public sealed class User : Entity, IAggregateRoot
{
    public string Name { get; set; }
    public string ProfilePicture { get; set; }
}
