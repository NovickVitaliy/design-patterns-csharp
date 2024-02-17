using Patterns.Structural.Bridge.Enums;

namespace Patterns.Structural.Bridge.Implementations.ConcreteImplementations;

public class MediumSize : ISize
{
    public BuildingSize Size => BuildingSize.Medium;
    public string GetSize()
    {
        return Enum.GetName(Size)!;
    }
}