namespace Patterns.Behavioral.Strategy.Interfaces;

public interface IRemoteRepository
{
    void PushToRepo(IEnumerable<string> commits);
}