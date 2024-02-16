using Patterns.Creational.Factories.FactoryMethod.Interfaces;

namespace Patterns.Creational.Factories.FactoryMethod;

public class AmdCpuFactory : ICpuFactory
{
    public ICpu CreateCpu()
    {
        return new AmdCpu();
    }
}