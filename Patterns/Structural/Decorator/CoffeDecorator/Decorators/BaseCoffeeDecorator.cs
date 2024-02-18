using Patterns.Structural.Decorator.CoffeDecorator.Interfaces;

namespace Patterns.Structural.Decorator.CoffeDecorator.Decorators;

public abstract class BaseCoffeeDecorator : ICoffee
{
    private readonly ICoffee _coffee;

    protected BaseCoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual string Drink()
    {
        return _coffee.Drink();
    }
}