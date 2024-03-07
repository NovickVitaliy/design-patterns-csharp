using Patterns.Creational.Factories.FactoryMethodViaAbstractClass.Interfaces;

namespace Patterns.Creational.Factories.FactoryMethodViaAbstractClass.Factories;

public abstract class CpuFactory
{
    public ICpu GetCpu()
    {
        return CreateCpu();
    }

    protected abstract ICpu CreateCpu();
}