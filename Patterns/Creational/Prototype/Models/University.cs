using Patterns.Creational.Prototype.Interfaces;

namespace Patterns.Creational.Prototype.Models;

public class University : IPrototype<University>
{
    public string Name { get; set; }
    public List<Student> Students { get; set; }
    public University()
    {
        
    }

    public University(University other)
    {
        Name = other.Name;
        Students = other.Students.Select(std => std.Clone()).ToList();
    }
    public University Clone()
    {
        return new University(this);
    }
}