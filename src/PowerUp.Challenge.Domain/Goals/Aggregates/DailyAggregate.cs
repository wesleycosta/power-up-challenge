using PowerUp.Challenge.Core.DomainObjects;

namespace PowerUp.Challenge.Domain.Goals.Aggregates;

public sealed class DailyAggregate : Entity
{
    public Guid UserId { get; set; }
    public int ConsecutiveDaysHitGoals { get; set; }
    public DateTimeOffset LastGoalCheckDate { get; set; }
}
