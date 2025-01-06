namespace Sork;

public class WhistleCommand : ICommand
{
    public bool Handles(string userInput) => userInput == "whistle";
    public CommandResult Execute()
    {
        Console.WriteLine("You whistle loudly");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}   