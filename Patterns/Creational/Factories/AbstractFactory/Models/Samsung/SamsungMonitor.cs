using Patterns.Creational.Factories.AbstractFactory.Interfaces;

namespace Patterns.Creational.Factories.AbstractFactory.Models.Samsung;

public class SamsungMonitor : IMonitor
{
    public void RenderImage()
    {
        Console.WriteLine("Samsung monitor is rendering image...");
    }
}