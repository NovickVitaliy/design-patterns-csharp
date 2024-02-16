using Patterns.Creational.Factories.FactoryMethod.Interfaces;

namespace Patterns.Creational.Factories.FactoryMethod;

public class IntelCpu : ICpu
{
    public void PerformOperation()
    {
        Console.WriteLine("Intel CPU is working...");
    }
}