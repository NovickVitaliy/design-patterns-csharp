namespace Patterns.Structural.Flyweight.Models;

public class Company
{
    public required string Name { get; set; } = string.Empty;
    public List<Developer> Developers { get; set; } = new();
}