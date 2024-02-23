namespace Patterns.Behavioral.Command.Receiver;

public class DownloaderService
{
    public void DownloadYoutubeVideo(string uri, int quality)
    {
        Console.WriteLine($"Downloading youtube video from: {uri} in {quality}px");
    }

    public void DownloadTiktokVideo(string uri)
    {
        Console.WriteLine($"Downloading tiktok video from: {uri}");
    }

    public void DownloadAudio(string uri, string format)
    {
        Console.WriteLine($"Donwloading audio in format: {format}");
    }
}