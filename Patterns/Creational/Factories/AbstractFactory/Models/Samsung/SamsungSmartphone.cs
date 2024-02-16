using Patterns.Creational.Factories.AbstractFactory.Interfaces;

namespace Patterns.Creational.Factories.AbstractFactory.Models.Samsung;

public class SamsungSmartphone : ISmartphone
{
    public void Call()
    {
        Console.WriteLine("Samsung phone is calling...");
    }
}