using Patterns.Structural.Composite.Interface;

namespace Patterns.Structural.Composite.Products;

public class Bread : IBox
{
    private readonly int _price;

    public Bread(int price)
    {
        _price = price;
    }

    public int GetPrice()
    {
        return _price;
    }
}