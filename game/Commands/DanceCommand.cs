namespace Sork.Commands;
using Sork.World;
public class DanceCommand : BaseCommand
{
    private readonly IUserInputOutput io;
    public DanceCommand(IUserInputOutput io)
    {
        this.io = io;
    }
    public override bool Handles(string userInput)
    {
        var paramsLength = GetParametersFromInput(userInput).Length;
        return GetCommandFromInput(userInput) == "dance" && (paramsLength == 0 || paramsLength == 1);
    }
    public override CommandResult Execute(string userInput, GameState gameState)
    {
        var parameters = GetParametersFromInput(userInput);
        if (parameters.Length == 0)
        {
            io.WriteNoun("You");
            io.WriteMessageLine(" dance awkwardly.");
        }
        else
        {
            io.WriteNoun("You");
            io.WriteMessage(" dance awkwardly with ");
            io.WriteNoun(parameters[0]);
            io.WriteMessageLine(".");
        }
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}