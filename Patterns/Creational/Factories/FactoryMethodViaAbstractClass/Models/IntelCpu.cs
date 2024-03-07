using Patterns.Creational.Factories.FactoryMethodViaAbstractClass.Interfaces;

namespace Patterns.Creational.Factories.FactoryMethodViaAbstractClass.Models;

public class IntelCpu : ICpu
{
    public void PerformWork()
    {
        Console.WriteLine("Intel cpu is working...");
    }
}