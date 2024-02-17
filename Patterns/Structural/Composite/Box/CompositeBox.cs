using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Patterns.Structural.Composite.Interface;

namespace Patterns.Structural.Composite.Box;

public class CompositeBox : IBox
{
    private readonly List<IBox> _items;

    public CompositeBox(params IBox[] items)
    {
        _items = new List<IBox>(items);
    }

    public int GetPrice()
    {
        return _items.Sum(item => item.GetPrice());
    }
}