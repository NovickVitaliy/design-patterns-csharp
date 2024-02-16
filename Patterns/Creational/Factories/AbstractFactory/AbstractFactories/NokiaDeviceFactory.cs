using Patterns.Creational.Factories.AbstractFactory.Interfaces;
using Patterns.Creational.Factories.AbstractFactory.Models.Nokia;

namespace Patterns.Creational.Factories.AbstractFactory.AbstractFactories;

public class NokiaDeviceFactory : IDeviceFactory
{
    public IMicrowave GetMicrowave()
    {
        return new NokiaMicrowave();
    }

    public IMonitor GetMonitor()
    {
        return new NokiaMonitor();
    }

    public ISmartphone GetSmartphone()
    {
        return new NokiaSmartphone();
    }
}