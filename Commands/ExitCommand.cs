namespace Sork.Commands;
using Sork.World;
public class ExitCommand : BaseCommand
{  
    public override bool Handles(string userInput) => GetCommandFromInput(userInput) == "exit";
    public override CommandResult Execute(string userInput, GameState gameState) => new CommandResult { RequestExit = true, IsHandled = true };
}