using Patterns.Structural.Bridge.Enums;

namespace Patterns.Structural.Bridge.Implementations.ConcreteImplementations;

public class LargeSize : ISize
{
    public BuildingSize Size => BuildingSize.Large;
    public string GetSize()
    {
        return Enum.GetName(Size)!;
    }
}