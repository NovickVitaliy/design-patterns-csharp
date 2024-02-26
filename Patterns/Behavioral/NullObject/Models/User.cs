using Patterns.Behavioral.NullObject.Implementations;
using Patterns.Behavioral.NullObject.Interfaces;

namespace Patterns.Behavioral.NullObject.Models;

public class User
{
    private static int _idRunner = 1;
    public int Id { get; set; } = _idRunner++;
    public string Username { get; set; } = string.Empty;
    public IPhoto Photo { get; set; } = new NullPhoto();
}