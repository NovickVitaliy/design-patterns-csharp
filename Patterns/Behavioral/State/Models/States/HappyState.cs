using Patterns.Behavioral.State.Interfaces;

namespace Patterns.Behavioral.State.Models.States;

public class HappyState : IEmotionalState
{
    public Person Person { get; set; }
 
    public HappyState(Person person)
    {
        Person = person;
    }

    public void Workout()
    {
        Console.WriteLine($"{Person.Name} is working on full power!!!");
        Person.ChangeMood(new ExhaustedState(Person));
    }

    public void Rest()
    {
        Console.WriteLine($"Such a good rest for {Person.Name}");
    }

    public void Sleep()
    {
        Console.WriteLine($"Such a nice sleep for {Person.Name}");
    }

    public void Eat()
    {
        Console.WriteLine($"What a nice food for {Person.Name}");
    }
}