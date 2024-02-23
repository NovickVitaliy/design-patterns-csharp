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
            return _next.Handle(internshipRequest);
        }

        Console.WriteLine("Applier does not have required hard skills");
        return false;
    }
}