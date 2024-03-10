using Patterns.Behavioral.Visitor.Interfaces;

namespace Patterns.Behavioral.Visitor.Models;

public class JsonVisitor : IVisitor
{
    public void Visit(VeryComplexObject veryComplexObject)
    {
        Console.WriteLine("Serializing very complex object to JSON");
    }

    public void Visit(VerySimpleObject verySimpleObject)
    {
        Console.WriteLine("Serializing very simple object to JSON");
    }
}