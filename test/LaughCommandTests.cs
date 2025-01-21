using Sork.Commands;
using Sork.World;

namespace Sork.Tests;

[TestClass]
public sealed class LaughCommandTests
{
    [TestMethod]
    public void Handle_ShouldReturnTrue_WhenCapitalizedInputIsProvided()
    {
        // Arrange
        var command = new LaughCommand(new UserInputOutput());
        // Act  
        var result = command.Handles("LOL");
        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Execute_ShouldOutputMessage()
    {
        // Arrange
        var io = new TestInputOutput();
        var command = new LaughCommand(io);
        var gameState = GameState.Create(io);

        // Act
        command.Execute("LOL", gameState);

        // Assert
        Assert.AreEqual("You", io.Outputs[0]);
        Assert.AreEqual(" laugh out loud, hysterically!", io.Outputs.Last());
    }
}
