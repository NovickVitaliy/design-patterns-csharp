using Patterns.Structural.Composite.Interface;

namespace Patterns.Structural.Composite.Products;

public class Varenyki : IBox
{
    private readonly int _price;

    public Varenyki(int price)
    {
        _price = price;
    }

    public int GetPrice()
    {
        return _price;
    }
}