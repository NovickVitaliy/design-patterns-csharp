using Patterns.Creational.Builder.Entity;

namespace Patterns.Creational.Builder.FunctionalBuilder;

public class ComputerFunctionalBuilder : IFunctionalBuilder<Computer>
{
    private Computer _computer;

    public ComputerFunctionalBuilder()
    {
        _computer = new Computer();
    }
    
    public IFunctionalBuilder<Computer> Configure(Action<Computer> action)
    {
        action(_computer);
        return this;
    }

    public Computer Build()
    {
        return _computer;
    }

    public IFunctionalBuilder<Computer> Reset()
    {
        _computer = new Computer();
        return this;
    }
}