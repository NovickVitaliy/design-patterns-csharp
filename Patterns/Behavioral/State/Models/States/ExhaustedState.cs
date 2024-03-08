using Patterns.Behavioral.State.Interfaces;

namespace Patterns.Behavioral.State.Models.States;

public class ExhaustedState : IEmotionalState
{
    public Person Person { get; set; }

    public ExhaustedState(Person person)
    {
        Person = person;
    }
    public void Workout()
    {
        Console.WriteLine($"{Person.Name} just passed out because of exhaustion...");
        Sleep();
    }

    public void Rest()
    {
        Console.WriteLine($"Rest was really good, {Person.Name} is full of power");
        Person.ChangeMood(new HappyState(Person));
    }

    public void Sleep()
    {
        Console.WriteLine($"Sleep was really helpfull for {Person.Name}");
        Person.ChangeMood(new HappyState(Person));
    }

    public void Eat()
    {
        Console.WriteLine($"Food was delicious and it gave power for {Person.Name}");
        Person.ChangeMood(new GoodMoodState(Person));
    }
}