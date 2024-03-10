using Patterns.Behavioral.Visitor.Interfaces;
using Patterns.Behavioral.Visitor.Models;

namespace Patterns.Behavioral.Visitor;

public class VisitorProgram
{
    public static void Main(string[] args)
    {
        IVisitor jsonVisitor = new JsonVisitor();
        IVisitor xmlVisitor = new XmlVisitor();

        VeryComplexObject veryComplexObject = new VeryComplexObject();
        veryComplexObject.Accept(jsonVisitor);
        veryComplexObject.Accept(xmlVisitor);

        VerySimpleObject verySimpleObject = new VerySimpleObject();
        verySimpleObject.Accept(jsonVisitor);
        verySimpleObject.Accept(xmlVisitor);
    }
}