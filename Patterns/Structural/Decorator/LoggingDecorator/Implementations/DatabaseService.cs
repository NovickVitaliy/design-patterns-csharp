using Patterns.Structural.Decorator.LoggingDecorator.Interfaces;

namespace Patterns.Structural.Decorator.LoggingDecorator.Implementations;

public class DatabaseService : IDatabaseService
{
    public IEnumerable<string> RetrieveData()
    {
        return new[] {"data1", "data2", "data3" };
    }
}