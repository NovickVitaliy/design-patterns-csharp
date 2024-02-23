using Patterns.Behavioral.Command.Interface;
using Patterns.Behavioral.Command.Receiver;

namespace Patterns.Behavioral.Command.Commands;

public class DownloadAudioCommand : ICommand
{
    private readonly DownloaderService _downloaderService;
    private readonly string _uri;
    private readonly string _format;

    public DownloadAudioCommand(DownloaderService downloaderService, string uri, string format)
    {
        _downloaderService = downloaderService;
        _uri = uri;
        _format = format;
    }

    public void Execute()
    {
        _downloaderService.DownloadAudio(_uri, _format);
    }
}