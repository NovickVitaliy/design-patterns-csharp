using Patterns.Creational.Factories.FactoryMethodViaAbstractClass.Factories;
using Patterns.Creational.Factories.FactoryMethodViaAbstractClass.Interfaces;

namespace Patterns.Creational.Factories.FactoryMethodViaAbstractClass;

public class FactoryMethodViaAbstractClassProgram
{
    public static void FactoryMethodViaAbstractClassMain(string[] args)
    {
        CpuFactory cpuFactory = new AmdCpuFactory();
        ICpu cpu = cpuFactory.GetCpu();
        cpu.PerformWork();
        cpuFactory = new IntelCpuFactory();
        cpu = cpuFactory.GetCpu();
        cpu.PerformWork();
    }
}