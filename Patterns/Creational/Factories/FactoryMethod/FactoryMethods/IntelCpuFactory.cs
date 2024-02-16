using Patterns.Creational.Factories.FactoryMethod.Interfaces;

namespace Patterns.Creational.Factories.FactoryMethod;

public class IntelCpuFactory : ICpuFactory
{
    public ICpu CreateCpu()
    {
        return new IntelCpu();
    }
}