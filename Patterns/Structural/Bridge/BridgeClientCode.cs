using Patterns.Structural.Bridge.Interfaces;

namespace Patterns.Structural.Bridge;

public class BridgeClientCode
{
    private readonly IBuilding _building;

    public BridgeClientCode(IBuilding building)
    {
        _building = building;
    }

    public void CreateBuilding()
    {
        _building.Build();
    }
}