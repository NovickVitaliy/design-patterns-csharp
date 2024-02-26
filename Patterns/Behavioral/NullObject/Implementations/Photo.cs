using Patterns.Behavioral.NullObject.Interfaces;

namespace Patterns.Behavioral.NullObject.Implementations;

public class Photo : IPhoto
{
    public string Url { get; set; } = null!;
}