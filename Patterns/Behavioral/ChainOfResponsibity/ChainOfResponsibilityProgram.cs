using Patterns.Behavioral.ChainOfResponsibity.Common;
using Patterns.Behavioral.ChainOfResponsibity.Handlers;
using Patterns.Behavioral.ChainOfResponsibity.Models;

namespace Patterns.Behavioral.ChainOfResponsibity;

public class ChainOfResponsibilityProgram
{
    public static void ChainOfResponsibilityMain(string[] args)
    {
        InternshipRequest niceRequest = new InternshipRequest()
        {
            SoftSkillsLevel = SoftSkillsLevel.Medium,
            KnownTechnologies = new List<string>()
            {
                "ASP.NET"
            }
        };

        InternshipRequest badRequest = new InternshipRequest()
        {
            KnownTechnologies = new List<string>()
            {
                "ASP.NET"
            },
            SoftSkillsLevel = SoftSkillsLevel.Low
        };

        InternshipHandler first = new TechnicalInterviewForDotNetDeveloperHandler();
        InternshipHandler second = new CtoInterviewHandler();
        first.SetNext(second);

        Console.WriteLine(first.Handle(niceRequest));
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine(first.Handle(badRequest));
    }
}