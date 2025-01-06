namespace Sork.Commands;

public class LaughCommand : ICommand
{
    private readonly UserInputOutput io;
    public LaughCommand(UserInputOutput io)
    {
        this.io = io;
    }
    public bool Handles(string userInput)
    {
        return userInput == "lol";
    }

    public CommandResult Execute()
    {
        io.WriteMessageLine("You laugh out loud, hysterically!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}