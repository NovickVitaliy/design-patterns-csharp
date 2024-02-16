using Patterns.Creational.Factories.AbstractFactory.Interfaces;

namespace Patterns.Creational.Factories.AbstractFactory.Models.Nokia;

public class NokiaSmartphone : ISmartphone
{
    public void Call()
    {
        Console.WriteLine("Nokia smartphone is calling");
    }
}