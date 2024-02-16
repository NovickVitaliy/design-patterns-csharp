using Patterns.Creational.Factories.AbstractFactory.Interfaces;
using Patterns.Creational.Factories.AbstractFactory.Models.Samsung;

namespace Patterns.Creational.Factories.AbstractFactory.AbstractFactories;

public class SamsungDeviceFactory : IDeviceFactory
{
    public IMicrowave GetMicrowave()
    {
        return new SamsungMicrowave();
    }

    public IMonitor GetMonitor()
    {
        return new SamsungMonitor();
    }

    public ISmartphone GetSmartphone()
    {
        return new SamsungSmartphone();
    }
}