using Patterns.Structural.Bridge.Enums;

namespace Patterns.Structural.Bridge.Implementations;

public interface ISize
{
    BuildingSize Size { get; }
    string GetSize();
}