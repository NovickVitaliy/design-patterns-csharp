using Patterns.Creational.Factories.FactoryMethodViaAbstractClass.Interfaces;

namespace Patterns.Creational.Factories.FactoryMethodViaAbstractClass.Models;

public class AmdCpu : ICpu
{
    public void PerformWork()
    {
        Console.WriteLine("Amd cpu is working...");
    }
}