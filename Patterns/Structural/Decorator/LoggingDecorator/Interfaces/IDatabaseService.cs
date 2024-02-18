namespace Patterns.Structural.Decorator.LoggingDecorator.Interfaces;

public interface IDatabaseService
{
    IEnumerable<string> RetrieveData();
}