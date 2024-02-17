using Patterns.Structural.Composite.Interface;

namespace Patterns.Structural.Composite.Products;

public class Milk : IBox
{
    private readonly int _price;

    public Milk(int price)
    {
        _price = price;
    }

    public int GetPrice()
    {
        return _price;
    }
}