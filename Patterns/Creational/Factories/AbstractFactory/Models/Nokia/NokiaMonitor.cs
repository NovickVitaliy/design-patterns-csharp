using Patterns.Creational.Factories.AbstractFactory.Interfaces;

namespace Patterns.Creational.Factories.AbstractFactory.Models.Nokia;

public class NokiaMonitor : IMonitor
{
    public void RenderImage()
    {
        Console.WriteLine("Nokid monitor is rendering image");
    }
}