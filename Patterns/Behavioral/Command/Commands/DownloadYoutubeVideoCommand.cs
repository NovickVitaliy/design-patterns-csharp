using Patterns.Behavioral.Command.Interface;
using Patterns.Behavioral.Command.Receiver;

namespace Patterns.Behavioral.Command.Commands;

public class DownloadYoutubeVideoCommand : ICommand
{
    private readonly DownloaderService _downloaderService;
    private readonly string _uri;
    private readonly int _quality;

    public DownloadYoutubeVideoCommand(DownloaderService downloaderService, string uri, int quality)
    {
        _downloaderService = downloaderService;
        _uri = uri;
        _quality = quality;
    }

    public void Execute()
    {
        _downloaderService.DownloadYoutubeVideo(_uri, _quality);
    }
}