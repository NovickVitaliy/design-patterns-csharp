using Patterns.Behavioral.ChainOfResponsibity.Models;

namespace Patterns.Behavioral.ChainOfResponsibity.Common;

public abstract class InternshipHandler
{
    protected InternshipHandler _next;

    public InternshipHandler SetNext(InternshipHandler nextHandler)
    {
        _next = nextHandler;
        return nextHandler;
    }

    public abstract bool Handle(InternshipRequest internshipRequest);
}