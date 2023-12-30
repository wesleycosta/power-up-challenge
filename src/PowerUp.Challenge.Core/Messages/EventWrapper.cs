namespace PowerUp.Challenge.Core.Messages;

public sealed class EventWrapper(Guid traceId,
    object @event)
{
    public string Type { get; private set; }
    public Guid TraceId { get; set; } = traceId;
    public object Event { get; private set; } = @event;
}
