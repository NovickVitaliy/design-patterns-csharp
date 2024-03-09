using System.Collections.Immutable;
using Patterns.Behavioral.Strategy.Interfaces;

namespace Patterns.Behavioral.Strategy;

public class Workspace
{
    private IRemoteRepository _remoteRepository;
    private readonly ICollection<string> _localCommits;
    private readonly ICollection<string> _globalCommits;
    
    public Workspace(IRemoteRepository remoteRepository)
    {
        _remoteRepository = remoteRepository;
        _localCommits = new List<string>();
        _globalCommits = new List<string>();
    }

    public void SetRemoteRepository(IRemoteRepository remoteRepository)
    {
        _remoteRepository = remoteRepository;
    }

    public void PushCommits()
    {
        foreach (var s in _localCommits) 
            _globalCommits.Add(s);
        
        _remoteRepository.PushToRepo(_localCommits);
        _localCommits.Clear();
    }

    public void Commit(string message)
    {
        _localCommits.Add(message);
    }

    public IImmutableList<string> GetCommits()
    {
        return _globalCommits.ToImmutableList();
    }
}