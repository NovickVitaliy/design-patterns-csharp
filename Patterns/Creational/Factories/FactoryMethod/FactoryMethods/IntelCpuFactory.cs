using Patterns.Creational.Factories.FactoryMethod.Interfaces;

namespace Patterns.Creational.Factories.FactoryMethod.FactoryMethods;

public class IntelCpuFactory : ICpuFactory
{
    public ICpu CreateCpu()
    {
        return new IntelCpu();
    }
}