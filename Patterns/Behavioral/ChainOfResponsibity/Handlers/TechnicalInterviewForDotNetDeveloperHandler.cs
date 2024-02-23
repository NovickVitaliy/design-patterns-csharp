using Patterns.Behavioral.ChainOfResponsibity.Common;
using Patterns.Behavioral.ChainOfResponsibity.Models;

namespace Patterns.Behavioral.ChainOfResponsibity.Handlers;

public class TechnicalInterviewForDotNetDeveloperHandler : InternshipHandler
{
    public override bool Handle(InternshipRequest internshipRequest)
    {
        Console.WriteLine("Technical interview handler...");
        if (internshipRequest.KnownTechnologies.Contains("ASP.NET"))
        {
            if (_next != null)
            {
                return _next.Handle(internshipRequest);
            }

            return true;
        }

        Console.WriteLine("Applier does not have required hard skills");
        return false;
    }
}