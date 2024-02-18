namespace Patterns.Structural.Facade.ThirdPartyLibrary;

public class ThirdPartyService
{
    private readonly Connection _connection;

    public ThirdPartyService(Connection connection)
    {
        _connection = connection;
    }

    public int[] ProcessData(params int[] numbers)
    {
        int[] result = Array.Empty<int>();
        if (_connection.IsOpened)
        {
            Console.WriteLine("Processing data...");
            result = numbers.Select(num => num * num).ToArray();
            Console.WriteLine("Processing data finished.");
        }
        else
        {
            Console.WriteLine("Connection is not opened. Cannot connect.");
        }

        return result;
    }
    
    
}