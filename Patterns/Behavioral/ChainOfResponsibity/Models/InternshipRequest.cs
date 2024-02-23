namespace Patterns.Behavioral.ChainOfResponsibity.Models;

public class InternshipRequest
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public byte Age { get; set; }
    public List<string> KnownTechnologies { get; set; } = new();
    public EnglishLevel EnglishLevel { get; set; }
    public SoftSkillsLevel SoftSkillsLevel { get; set; }
    public TimeSpan TimeExperience { get; set; }
}