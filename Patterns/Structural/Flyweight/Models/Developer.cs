namespace Patterns.Structural.Flyweight.Models;

public class Developer
{
    public required string FirstName { get; set; } = string.Empty;
    public required string LastName { get; set; } = string.Empty;
    public required ProgrammingLanguage ProgrammingLanguage { get; set; }
    public required Company Company { get; set; }
}