namespace Patterns.Behavioral.Visitor.Interfaces;

public interface IVisitable
{
    void Accept(IVisitor visitor);
}