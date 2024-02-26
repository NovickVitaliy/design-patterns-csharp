using Patterns.Behavioral.NullObject.Interfaces;

namespace Patterns.Behavioral.NullObject.Implementations;

public class NullPhoto : IPhoto
{
    public string Url { get; set; } = "path/to/default/photo";
}