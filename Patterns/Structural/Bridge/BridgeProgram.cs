using Patterns.Structural.Bridge.Abstractions.RefinedAbstractions;
using Patterns.Structural.Bridge.Implementations.ConcreteImplementations;
using Patterns.Structural.Bridge.Interfaces;

namespace Patterns.Structural.Bridge;

public class BridgeProgram
{
    public static void BridgeMain(string[] args)
    {
        IBuilding house = new House(new SmallSize());
        IBuilding apartmentsBuilding = new ApartmentsBuilding(new LargeSize());
        IBuilding dormitory = new Dormitory(new MediumSize());
        
        BridgeClientCode bridgeClientCodeUsingHouse = new BridgeClientCode(house);
        BridgeClientCode bridgeClientCodeUsingApartmentsBuilding = new BridgeClientCode(apartmentsBuilding);
        BridgeClientCode bridgeClientCodeUsingDormitory = new BridgeClientCode(dormitory);
        bridgeClientCodeUsingHouse.CreateBuilding();
        bridgeClientCodeUsingApartmentsBuilding.CreateBuilding();
        bridgeClientCodeUsingDormitory.CreateBuilding();
    }
}