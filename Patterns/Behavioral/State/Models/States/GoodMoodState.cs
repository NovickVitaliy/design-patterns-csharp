using Patterns.Behavioral.State.Interfaces;

namespace Patterns.Behavioral.State.Models.States;

public class GoodMoodState : IEmotionalState
{
    public Person Person { get; set; }

    public GoodMoodState(Person person)
    {
        Person = person;
    }
    public void Workout()
    {
        Console.WriteLine("Gains are pretty good!!!");
        Person.ChangeMood(new ExhaustedState(Person));
    }

    public void Rest()
    {
        Console.WriteLine($"Rest is really good for {Person.Name}");
    }

    public void Sleep()
    {
        Console.WriteLine($"Sleep was really good for {Person.Name}");
    }

    public void Eat()
    {
        Console.WriteLine($"Such delicious food for {Person.Name}");
    }
}