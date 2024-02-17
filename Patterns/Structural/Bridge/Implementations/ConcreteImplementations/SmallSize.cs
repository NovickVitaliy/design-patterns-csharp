using Patterns.Structural.Bridge.Enums;

namespace Patterns.Structural.Bridge.Implementations.ConcreteImplementations;

public class SmallSize : ISize
{
    public BuildingSize Size => BuildingSize.Small;
    public string GetSize()
    {
        return Enum.GetName(Size)!;
    }
}