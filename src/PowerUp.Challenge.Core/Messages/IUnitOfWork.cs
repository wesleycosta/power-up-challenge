namespace PowerUp.Challenge.Core.Messages;

public interface IUnitOfWork
{
    Task<bool> Commit();
}
