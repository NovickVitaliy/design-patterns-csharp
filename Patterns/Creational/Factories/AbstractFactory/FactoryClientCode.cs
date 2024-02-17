using Patterns.Creational.Factories.AbstractFactory.Interfaces;

namespace Patterns.Creational.Factories.AbstractFactory;

public class FactoryClientCode
{
    private readonly IDeviceFactory _deviceFactory;

    public FactoryClientCode(IDeviceFactory deviceFactory)
    {
        _deviceFactory = deviceFactory;
    }

    public void PerformWorkWithMicrowave()
    {
        _deviceFactory.GetMicrowave().HeatFood();
    }

    public void PerformWorkWithSmartphone()
    {
        _deviceFactory.GetSmartphone().Call();
    }

    public void PerformWorkWithMonitor()
    {
        _deviceFactory.GetMonitor().RenderImage();
    }
}