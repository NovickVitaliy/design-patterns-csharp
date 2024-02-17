using Patterns.Creational.Factories.FactoryMethod.FactoryMethods;
using Patterns.Creational.Factories.FactoryMethod.Interfaces;

namespace Patterns.Creational.Factories.FactoryMethod;

public class FactoryMethodProgram
{
    public static void FactoryMethodMain(string[] args)
    {
        ICpuFactory intelFactory = new IntelCpuFactory();
        ICpuFactory amdFactory = new AmdCpuFactory();

        FactoryMethodClientCode factoryMethodClientCodeUsingIntelFactory = new FactoryMethodClientCode(intelFactory);
        factoryMethodClientCodeUsingIntelFactory.PerformWorkWithCpu();
        FactoryMethodClientCode factoryMethodClientCodeUsingAmdFactory = new FactoryMethodClientCode(amdFactory);
        factoryMethodClientCodeUsingAmdFactory.PerformWorkWithCpu();
        
    }
}