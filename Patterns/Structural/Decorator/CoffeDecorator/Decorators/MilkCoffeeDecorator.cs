using Patterns.Structural.Decorator.CoffeDecorator.Interfaces;

namespace Patterns.Structural.Decorator.CoffeDecorator.Decorators;

public class MilkCoffeeDecorator : BaseCoffeeDecorator
{
    public MilkCoffeeDecorator(ICoffee coffee) : base(coffee)
    { }

    public override string Drink()
    {
        return base.Drink() + ". Added milk";
    }
}