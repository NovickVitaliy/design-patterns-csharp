using Patterns.Structural.Bridge.Implementations;
using Patterns.Structural.Bridge.Interfaces;

namespace Patterns.Structural.Bridge.Abstractions.RefinedAbstractions;

public class ApartmentsBuilding : IBuilding
{
    private readonly ISize _size;

    public ApartmentsBuilding(ISize size)
    {
        _size = size;
    }

    public void Build()
    {
        Console.WriteLine($"Building apartment building in size of {_size.GetSize()}");
    }
}