namespace Patterns.Behavioral.Iterator;

public class IteratorProgram
{
    public static void IteratorMain(string[] args)
    {
        GitHubRepository gitHubRepository = new GitHubRepository();
        
        gitHubRepository.CommitChanges("initial commit");
        gitHubRepository.CommitChanges("added navbar");
        gitHubRepository.CommitChanges("added footer");
        gitHubRepository.CommitChanges("added main page");
        gitHubRepository.CommitChanges("add register form");
        gitHubRepository.CommitChanges("add login form");
        gitHubRepository.CommitChanges("fixed spacing in register form");

        var iterator = gitHubRepository.GetIterator();
        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.GetNext());
        }
    }
}