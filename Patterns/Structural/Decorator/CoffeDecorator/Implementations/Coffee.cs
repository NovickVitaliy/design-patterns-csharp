using Patterns.Structural.Decorator.CoffeDecorator.Interfaces;

namespace Patterns.Structural.Decorator.CoffeDecorator.Implementations;

public class Coffee : ICoffee
{
    public string Drink()
    {
        return "Drinking coffee";
    }
}