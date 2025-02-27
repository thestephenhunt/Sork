using Sork.World;
namespace Sork.Commands;

public class WhistleCommand : BaseCommand
{
    private readonly IUserInputOutput io;
    public WhistleCommand(IUserInputOutput io)
    {
        this.io = io;
    }
    public override bool Handles(string userInput) => GetCommandFromInput(userInput) == "whistle";
    public override CommandResult Execute(string userInput, GameState gameState)
    {
        io.WriteNoun("You");
        io.WriteMessageLine(" whistle loudly.");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}