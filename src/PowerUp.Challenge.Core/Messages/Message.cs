﻿namespace PowerUp.Challenge.Core.Messages;

public abstract class Message
{
    public string MessageType { get; protected set; }
    public Guid AggregateId { get; init; }

    protected Message() =>
        MessageType = GetType().Name;
}
