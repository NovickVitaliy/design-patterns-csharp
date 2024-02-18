using Patterns.Structural.Decorator.LoggingDecorator.Interfaces;

namespace Patterns.Structural.Decorator.LoggingDecorator.Decorators;

public class LoggingDatabaseServiceDecorator : BaseDatabaseServiceDecorator
{
    public LoggingDatabaseServiceDecorator(IDatabaseService databaseService) : base(databaseService)
    { }

    public override IEnumerable<string> RetrieveData()
    {
        Console.WriteLine("Retrieving data from database...");
        var data = base.RetrieveData();
        Console.WriteLine("Data retrieval finished.");
        return data;
    }
}