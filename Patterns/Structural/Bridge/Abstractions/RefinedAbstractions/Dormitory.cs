using Patterns.Structural.Bridge.Implementations;
using Patterns.Structural.Bridge.Interfaces;

namespace Patterns.Structural.Bridge.Abstractions.RefinedAbstractions;

public class Dormitory : IBuilding
{
    private readonly ISize _size;

    public Dormitory(ISize size)
    {
        _size = size;
    }

    public void Build()
    {
        Console.WriteLine($"Building dormitory in size of {_size.GetSize()}");
    }
}