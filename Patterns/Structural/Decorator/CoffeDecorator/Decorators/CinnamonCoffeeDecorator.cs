using Patterns.Structural.Decorator.CoffeDecorator.Interfaces;

namespace Patterns.Structural.Decorator.CoffeDecorator.Decorators;

public class CinnamonCoffeeDecorator : BaseCoffeeDecorator
{
    public CinnamonCoffeeDecorator(ICoffee coffee) : base(coffee)
    { }

    public override string Drink()
    {
        return base.Drink() + ". Added cinnamon";
    }
}