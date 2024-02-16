using Patterns.Creational.Prototype.Interfaces;

namespace Patterns.Creational.Prototype.Models;

public class Person : IPrototype<Person>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; }
    public Person(Person other)
    {
        FirstName = other.FirstName;
        LastName = other.LastName;
        Age = other.Age;
    }

    public Person()
    {
    }

    public Person Clone()
    {
        return new Person(this);
    }
}