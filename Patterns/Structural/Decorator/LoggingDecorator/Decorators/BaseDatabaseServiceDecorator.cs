using Patterns.Structural.Decorator.LoggingDecorator.Interfaces;

namespace Patterns.Structural.Decorator.LoggingDecorator.Decorators;

public abstract class BaseDatabaseServiceDecorator : IDatabaseService
{
    private readonly IDatabaseService _databaseService;

    protected BaseDatabaseServiceDecorator(IDatabaseService databaseService)
    {
        _databaseService = databaseService;
    }

    public virtual IEnumerable<string> RetrieveData()
    {
        return _databaseService.RetrieveData();
    }
}