namespace Sork.Commands;
using Sork.World;

public class TakeCommand : BaseCommand
{
    private readonly IUserInputOutput io;

    public TakeCommand(IUserInputOutput io)
    {
        this.io = io;
    }

    public override bool Handles(string input)
    {
        return GetCommandFromInput(input) == "take";
    }

    public override CommandResult Execute(string userInput, GameState gameState)
    {
        var paramters = GetParametersFromInput(userInput);
        if (paramters.Length == 0)
        {
            io.WriteMessageLine("You must specify an item to take.");
            return new CommandResult() { RequestExit = false, IsHandled = false };
        }
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}
