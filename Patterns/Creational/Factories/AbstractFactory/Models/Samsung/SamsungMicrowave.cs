using Patterns.Creational.Factories.AbstractFactory.Interfaces;

namespace Patterns.Creational.Factories.AbstractFactory.Models.Samsung;

public class SamsungMicrowave : IMicrowave
{
    public void HeatFood()
    {
        Console.WriteLine("Samsung microwave is heating food...");
    }
}