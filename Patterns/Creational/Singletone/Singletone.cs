namespace Patterns.Creational.Singletone;

public class Singletone
{
    private static readonly Lazy<Singletone> _lazyInstance
        = new Lazy<Singletone>(() => new Singletone());

    private Singletone()
    {
    }

    public string[] GetData()
    {
        return new[] { "data1", "data2" };
    }

    public static Singletone Instance => _lazyInstance.Value;
}