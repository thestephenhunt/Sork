public class SingCommand : ICommand
{
    public bool Handles(string userInput) => userInput == "sing";
    public CommandResult Execute()
    {
        Console.WriteLine("You sing off key");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}  