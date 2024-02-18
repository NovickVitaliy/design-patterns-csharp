using Patterns.Structural.Decorator.LoggingDecorator.Decorators;
using Patterns.Structural.Decorator.LoggingDecorator.Implementations;
using Patterns.Structural.Decorator.LoggingDecorator.Interfaces;

namespace Patterns.Structural.Decorator.LoggingDecorator;

public class LoggingDecoratorProgram
{
    public static void LogginDecoratorMain(string[] args)
    {
        IDatabaseService databaseService = new DatabaseService();
        IDatabaseService databaseServiceWithLogging = new LoggingDatabaseServiceDecorator(databaseService);

        Console.WriteLine("Without logging");
        var data = databaseService.RetrieveData();
        data.ToList().ForEach(Console.WriteLine);
        Console.WriteLine();

        Console.WriteLine("With logging");
        var retrieveData = databaseServiceWithLogging.RetrieveData();
        retrieveData.ToList().ForEach(Console.WriteLine);
    }
}