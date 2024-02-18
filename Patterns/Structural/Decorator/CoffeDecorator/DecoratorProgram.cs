using Patterns.Structural.Decorator.CoffeDecorator.Decorators;
using Patterns.Structural.Decorator.CoffeDecorator.Implementations;
using Patterns.Structural.Decorator.CoffeDecorator.Interfaces;

namespace Patterns.Structural.Decorator.CoffeDecorator;

public class CoffeeDecoratorProgram
{
    public static void CoffeeDecoratorMain(string[] args)
    {
        ICoffee coffee = new MilkCoffeeDecorator(new CinnamonCoffeeDecorator(new Coffee()));

        Console.WriteLine(coffee.Drink());
    }
}