using PowerUp.Challenge.Core.DomainObjects;

namespace PowerUp.Challenge.Domain.Goals.Aggregates;

public sealed class Goal : Entity, IAggregateRoot
{
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public int WeeklyTargetFrequency { get; set; }
    public GoalType Type { get; set; }
}
