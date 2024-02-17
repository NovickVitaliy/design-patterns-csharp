namespace Patterns.Structural.Adapter;

public class ClientCode
{
    private readonly INewService _newService;

    public ClientCode(INewService newService)
    {
        _newService = newService;
    }

    public void ShowData1()
    {
        Console.WriteLine(_newService.Data1());
    }

    public void ShowData2()
    {
        Console.WriteLine(_newService.Data2());
    }
}