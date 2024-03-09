using Patterns.Behavioral.Strategy.Interfaces;

namespace Patterns.Behavioral.Strategy.Implementations;

public class GitHub : IRemoteRepository
{
    public void PushToRepo(IEnumerable<string> commits)
    {
        Console.WriteLine($"Pushing {commits.Count()} commits to GitHub");
    }
}