using Patterns.Structural.Composite.Box;
using Patterns.Structural.Composite.Interface;
using Patterns.Structural.Composite.Products;

namespace Patterns.Structural.Composite;

public class CompositeProgram
{
    public static void CompositeMain(string[] args)
    {
        IBox compositeBox = new CompositeBox(
            new Bread(100),
            new Varenyki(200), 
            new CompositeBox(new Bread(500), new Milk(1238)),
            new Milk(50));

        var price = compositeBox.GetPrice();

        Console.WriteLine(price);
    }
}