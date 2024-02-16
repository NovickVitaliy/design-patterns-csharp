using Patterns.Creational.Factories.FactoryMethod.Interfaces;

namespace Patterns.Creational.Factories.FactoryMethod;

public class AmdCpu : ICpu
{
    public void PerformOperation()
    {

        Console.WriteLine("Amd CPU is working...");
    }
}