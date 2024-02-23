using Patterns.Behavioral.ChainOfResponsibity.Common;
using Patterns.Behavioral.ChainOfResponsibity.Models;

namespace Patterns.Behavioral.ChainOfResponsibity.Handlers;

public class CtoInterviewHandler : InternshipHandler
{
    public override bool Handle(InternshipRequest internshipRequest)
    {
        Console.WriteLine("Cto interview handler...");
        if (internshipRequest.SoftSkillsLevel is SoftSkillsLevel.Medium or SoftSkillsLevel.Medium)
        {
            if (_next != null)
            {
                return _next.Handle(internshipRequest);
            }
            return true;
        }

        Console.WriteLine("Applier does not have required level of soft skills");
        return false;
    }
}