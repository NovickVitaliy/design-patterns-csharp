using Patterns.Behavioral.Command.Interface;
using Patterns.Behavioral.Command.Receiver;

namespace Patterns.Behavioral.Command.Commands;

public class DownloadTikTokVideoCommand : ICommand
{
    private readonly DownloaderService _downloaderService;
    private readonly string _uri;

    public DownloadTikTokVideoCommand(DownloaderService downloaderService, string uri)
    {
        _downloaderService = downloaderService;
        _uri = uri;
    }

    public void Execute()
    {
        _downloaderService.DownloadTiktokVideo(_uri);
    }
}