using Patterns.Creational.Prototype.Interfaces;

namespace Patterns.Creational.Prototype.Models;

public class Student : Person, IPrototype<Student>
{
    public University University { get; set; }
    public Student()
    {
        
    }
    public Student(Student other) : base(other)
    {
        University = other.University.Clone();
    }

    public Student Clone()
    {
        return new Student(this);
    }
}