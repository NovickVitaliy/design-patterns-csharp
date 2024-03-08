using Patterns.Behavioral.State.Interfaces;
using Patterns.Behavioral.State.Models.States;

namespace Patterns.Behavioral.State.Models;

public class Person
{
    public string Name { get; }
    private IEmotionalState _emotionalState;
    public Person(string name)
    {
        Name = name;
        _emotionalState = new HappyState(this);
    }

    public void Workout()
    {
        Console.WriteLine($"{Name} is starting workout...");
        _emotionalState.Workout();
    }

    public void Rest()
    {
        Console.WriteLine($"{Name} is resting...");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} goes to bed...");
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} has chosen food...");
    }

    public void ChangeMood(IEmotionalState emotionalState)
    {
        _emotionalState = emotionalState;
    }
}