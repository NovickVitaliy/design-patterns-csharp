namespace Patterns.Structural.Adapter;

public class Program
{
    public static void Main(string[] args)
    {
        INewService newService = new NewService();
        INewService adapterLegacyService = new LegacyServiceAdapter(new LegacyService());

        var clientCode = new ClientCode(newService);
        clientCode.ShowData1();
        clientCode.ShowData2();

        var clientCode2 = new ClientCode(adapterLegacyService);
        clientCode2.ShowData1();
        clientCode2.ShowData2();
    }
}