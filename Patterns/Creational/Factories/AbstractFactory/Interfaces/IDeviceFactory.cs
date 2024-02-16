namespace Patterns.Creational.Factories.AbstractFactory.Interfaces;

public interface IDeviceFactory
{
    IMicrowave GetMicrowave();
    IMonitor GetMonitor();
    ISmartphone GetSmartphone();
}