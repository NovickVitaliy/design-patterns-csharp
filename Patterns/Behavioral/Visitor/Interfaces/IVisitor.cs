using Patterns.Behavioral.Visitor.Models;

namespace Patterns.Behavioral.Visitor.Interfaces;

public interface IVisitor
{
    void Visit(VeryComplexObject veryComplexObject);
    void Visit(VerySimpleObject verySimpleObject);
}