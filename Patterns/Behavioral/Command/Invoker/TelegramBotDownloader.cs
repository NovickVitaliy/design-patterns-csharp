using Patterns.Behavioral.Command.Interface;
using Patterns.Behavioral.Command.Receiver;

namespace Patterns.Behavioral.Command.Invoker;

public class TelegramBotDownloader
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void Download()
    {
        _command.Execute();
    }
}