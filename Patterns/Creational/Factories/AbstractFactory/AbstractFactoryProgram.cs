using Patterns.Creational.Factories.AbstractFactory.AbstractFactories;
using Patterns.Creational.Factories.AbstractFactory.Interfaces;

namespace Patterns.Creational.Factories.AbstractFactory;

public class AbstractFactoryProgram
{
    public static void AbstractFactoryMain(string[] args)
    {
        IDeviceFactory samsungFactory = new SamsungDeviceFactory();
        IDeviceFactory nokiaFactory = new NokiaDeviceFactory();

        FactoryClientCode factoryClientCodeUsingSamsungFactory = new FactoryClientCode(samsungFactory);
        factoryClientCodeUsingSamsungFactory.PerformWorkWithMicrowave();
        factoryClientCodeUsingSamsungFactory.PerformWorkWithMonitor();
        factoryClientCodeUsingSamsungFactory.PerformWorkWithSmartphone();

        FactoryClientCode factoryClientCodeUsingNokiaFactory = new FactoryClientCode(nokiaFactory);
        factoryClientCodeUsingNokiaFactory.PerformWorkWithMicrowave();
        factoryClientCodeUsingNokiaFactory.PerformWorkWithMonitor();
        factoryClientCodeUsingNokiaFactory.PerformWorkWithSmartphone();
    }
}