namespace Patterns.Structural.Facade.ThirdPartyLibrary;

public class Connection
{
    private bool _isOpened;

    public bool IsOpened => _isOpened;

    private string _secretKey;

    public Connection(string secretKey)
    {
        _secretKey = secretKey;
        _isOpened = false;
    }

    public void OpenConnection()
    {
        if (!_isOpened)
            _isOpened = true;
        else
            Console.WriteLine("Connection is already opened");
    }

    public void CloseConnection()
    {
        if (_isOpened)
            _isOpened = false;
        else
            Console.WriteLine("Connection is already closed");
    }
}