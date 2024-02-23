using Patterns.Behavioral.Command.Commands;
using Patterns.Behavioral.Command.Interface;
using Patterns.Behavioral.Command.Invoker;
using Patterns.Behavioral.Command.Receiver;

namespace Patterns.Behavioral.Command;

public class CommandProgram
{
    public static void CommandMain(string[] args)
    {
        DownloaderService downloaderService = new DownloaderService();
        TelegramBotDownloader telegramBotDownloader = new TelegramBotDownloader();
        ICommand youtubeVideo = new DownloadYoutubeVideoCommand(downloaderService, "someuri", 1080);
        ICommand tiktokVideo = new DownloadTikTokVideoCommand(downloaderService, "someuri");
        ICommand audio = new DownloadAudioCommand(downloaderService, "someuri", "mp4");
        
        telegramBotDownloader.SetCommand(youtubeVideo);
        telegramBotDownloader.Download();
        telegramBotDownloader.SetCommand(tiktokVideo);
        telegramBotDownloader.Download();
        telegramBotDownloader.SetCommand(audio);
        telegramBotDownloader.Download();
    }
}