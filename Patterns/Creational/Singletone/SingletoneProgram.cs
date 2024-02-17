namespace Patterns.Creational.Singletone;

public class SingletoneProgram
{
    public static void SingletoneMain(string[] args)
    {
        var singletone = Singletone.Instance;
        var strings = singletone.GetData();
        foreach (var s in strings)
        {
            Console.WriteLine(s);
        }

        Monostate monostate = new Monostate()
        {
            State1 = "state1",
            State2 = "state2"
        };
        Monostate monostate2 = new Monostate();
        Console.WriteLine(monostate.State1 == monostate2.State1);
        Console.WriteLine(monostate.State2 == monostate2.State2);
    }
}