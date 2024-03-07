using Patterns.Creational.Factories.FactoryMethodViaAbstractClass.Interfaces;
using Patterns.Creational.Factories.FactoryMethodViaAbstractClass.Models;

namespace Patterns.Creational.Factories.FactoryMethodViaAbstractClass.Factories;

public class AmdCpuFactory : CpuFactory
{
    protected override ICpu CreateCpu()
    {
        return new AmdCpu();
    }
}