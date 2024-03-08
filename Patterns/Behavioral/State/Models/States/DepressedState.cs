using Patterns.Behavioral.State.Interfaces;

namespace Patterns.Behavioral.State.Models.States;

public class DepressedState : IEmotionalState
{
    public Person Person { get; set; }

    public DepressedState(Person person)
    {
        Person = person;
    }
    public void Workout()
    {
        Console.WriteLine($"{Person.Name} did not workout well, they got no gains...");
    }

    public void Rest()
    {
        Console.WriteLine($"Rest really helped and helped {Person.Name} to get out of depressed state");
        Person.ChangeMood(new GoodMoodState(Person));
    }

    public void Sleep()
    {
        Console.WriteLine("Sleep did not go well... Slept only for few hours...");
    }

    public void Eat()
    {
        Console.WriteLine("Food was not really good...");
    }
}