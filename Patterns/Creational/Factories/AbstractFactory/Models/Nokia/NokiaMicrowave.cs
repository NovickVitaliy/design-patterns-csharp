using Patterns.Creational.Factories.AbstractFactory.Interfaces;

namespace Patterns.Creational.Factories.AbstractFactory.Models.Nokia;

public class NokiaMicrowave : IMicrowave
{
    public void HeatFood()
    {
        Console.WriteLine("Nokia microwave is heating food");
    }
}