using Patterns.Structural.Facade.ThirdPartyLibrary;

namespace Patterns.Structural.Facade;

public class FacadeProgram
{
    public static void FacadeMain(string[] args)
    {
        // example without Facade
        string connectionSecret = ConnectionSecretCreator.GetSecret("vitalii");
        Connection connection = new Connection(connectionSecret);
        ThirdPartyService thirdPartyService = new ThirdPartyService(connection);
        connection.OpenConnection();
        var processData = thirdPartyService.ProcessData(1, 2, 3, 4, 5, 6);
        DisplayProcessedData(processData);
        connection.CloseConnection();
        
        // example with Facade
        DataProcessor dataProcessor = new DataProcessor();
        var processedData = dataProcessor.GetProcessedData(1,2,3,4,5,6);
        DisplayProcessedData(processData);
    }

    private static void DisplayProcessedData(int[] data)
    {
        foreach (var i in data)
        {
            Console.Write($"{i}\t");
        }

        Console.WriteLine();
    }
}