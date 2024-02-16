namespace Patterns.Creational.Singletone;

public class Monostate
{
    private static string _state1 = string.Empty;
    private static string _state2 = string.Empty;

    public Monostate(string state1, string state2)
    {
        _state1 = state1;
        _state2 = state2;
    }

    public string State1
    {
        get => _state1;
        set => _state1 = value;
    }

    public string State2
    {
        get => _state2;
        set => _state2 = value;
    }
}