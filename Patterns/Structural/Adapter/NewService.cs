namespace Patterns.Structural.Adapter;

public class NewService : INewService
{
    public string Data1()
    {
        return "Data 1 from new service";
    }

    public string Data2()
    {
        return "Data 2 from new service";
    }
}