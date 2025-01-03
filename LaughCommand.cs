public class LaughCommand : ICommand
{
    public bool Handles(string userInput)
    {
        return userInput == "lol";
    }

    public CommandResult Execute()
    {
        Console.WriteLine("You laugh out loud, hysterically!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}