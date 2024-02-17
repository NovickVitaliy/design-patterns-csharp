namespace Patterns.Structural.Adapter;

public class LegacyServiceAdapter : INewService
{
    private readonly LegacyService _legacyService;

    public LegacyServiceAdapter(LegacyService legacyService)
    {
        _legacyService = legacyService;
    }

    public string Data1()
    {
        return _legacyService.GetServiceData1();
    }

    public string Data2()
    {
        return _legacyService.GetServiceData2();
    }
}