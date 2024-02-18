using Patterns.Structural.Facade.ThirdPartyLibrary;

namespace Patterns.Structural.Facade;

public class DataProcessor
{
    private readonly Connection _connection;
    private readonly ThirdPartyService _thirdPartyService;

    public DataProcessor()
    {
        string secret = ConnectionSecretCreator.GetSecret("vitalii");
        _connection = new Connection(secret);
        _thirdPartyService = new ThirdPartyService(_connection);
    }

    public int[] GetProcessedData(params int[] numbers)
    {
        _connection.OpenConnection();
        var data = _thirdPartyService.ProcessData(numbers);
        _connection.CloseConnection();
        return data;
    }
}