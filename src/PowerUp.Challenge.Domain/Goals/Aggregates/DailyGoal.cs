using PowerUp.Challenge.Core.DomainObjects;

namespace PowerUp.Challenge.Domain.Goals.Aggregates;

public sealed class DailyGoal : Entity
{
    public Guid UserId { get; set; }
    public Guid GoalId { get; set; }
    public DateTimeOffset Date { get; set; }
    public bool IsGoalAchieved { get; set; }
}
