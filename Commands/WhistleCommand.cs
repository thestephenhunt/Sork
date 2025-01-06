namespace Sork.Commands;

public class WhistleCommand : ICommand
{
    private readonly UserInputOutput io;
    public WhistleCommand(UserInputOutput io)
    {
        this.io = io;
    }
    public bool Handles(string userInput) => userInput == "whistle";
    public CommandResult Execute()
    {
        io.WriteMessageLine("You whistle loudly");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}   