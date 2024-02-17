using Patterns.Creational.Factories.FactoryMethod.Interfaces;

namespace Patterns.Creational.Factories.FactoryMethod;

public class FactoryMethodClientCode
{
    private readonly ICpuFactory _cpuFactory;

    public FactoryMethodClientCode(ICpuFactory cpuFactory)
    {
        _cpuFactory = cpuFactory;
    }

    public void PerformWorkWithCpu()
    {
        _cpuFactory.CreateCpu().PerformOperation();
    }
}