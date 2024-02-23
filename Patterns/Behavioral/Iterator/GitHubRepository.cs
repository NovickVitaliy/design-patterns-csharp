namespace Patterns.Behavioral.Iterator;

public class GitHubRepository
{
    private readonly List<string> _commitsHistory;

    public GitHubRepository()
    {
        _commitsHistory = new List<string>();
    }

    public void CommitChanges(string message)
    {
        _commitsHistory.Add(message);
    }

    public IIterator<string> GetIterator()
    {
        return new CommitIterator(_commitsHistory);
    }
    
    private class CommitIterator : IIterator<string>
    {
        private int _index = 0;
        private readonly List<string> _commitsHistory;
        public CommitIterator(List<string> commitsHistory)
        {
            _commitsHistory = commitsHistory;
        }
        public bool HasNext()
        {
            return _index < _commitsHistory.Count;
        }

        public string GetNext()
        {
            return _commitsHistory[_index++];
        }
    }
}