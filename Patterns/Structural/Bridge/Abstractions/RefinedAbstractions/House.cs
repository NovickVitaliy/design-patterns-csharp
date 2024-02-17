using Patterns.Structural.Bridge.Implementations;
using Patterns.Structural.Bridge.Interfaces;

namespace Patterns.Structural.Bridge.Abstractions.RefinedAbstractions;

public class House : IBuilding
{
    private readonly ISize _size;

    public House(ISize size)
    {
        _size = size;
    }

    public void Build()
    {
        Console.WriteLine($"Building house in size of {_size.GetSize()}");
    }
}