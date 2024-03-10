using Patterns.Behavioral.Visitor.Interfaces;

namespace Patterns.Behavioral.Visitor.Models;

public class VerySimpleObject : IVisitable
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}