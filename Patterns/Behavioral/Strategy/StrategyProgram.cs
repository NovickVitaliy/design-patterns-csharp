using Patterns.Behavioral.Strategy.Implementations;

namespace Patterns.Behavioral.Strategy;

public class StrategyProgram
{
    public static void StrategyMain(string[] args)
    {
        Workspace workspace = new Workspace(new GitHub());
        
        workspace.Commit("initial commit");
        workspace.Commit("another");
        workspace.PushCommits();
        
        workspace.SetRemoteRepository(new BitBucket());
        
        workspace.Commit("1");
        workspace.Commit("2");
        workspace.Commit("3");
        workspace.PushCommits();
        
        workspace.SetRemoteRepository(new GitLab());
        workspace.Commit("4");
        workspace.Commit("5");
        workspace.Commit("6");
        
        workspace.PushCommits();
    }
}