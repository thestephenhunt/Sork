
using Sork.Commands;
using Sork.World;

namespace Sork.Tests;

[TestClass]
public sealed class SingCommandTests
{
    [TestMethod]
    public void Execute_ShouldOutputMessage()
    {
        // Arrange
        var io = new TestInputOutput();
        var command = new SingCommand(io);
        var gameState = GameState.Create(io);

        // Act
        command.Execute("sing", gameState);

        // Assert
        Assert.AreEqual("You", io.Outputs[0]);
        Assert.AreEqual(" sing off key.", io.Outputs.Last());
    }

    [TestMethod]
    public void Handles_ShouldReturnTrue_WhenCapitalizedInputIsProvided()
    {
        // Arrange
        var command = new SingCommand(new UserInputOutput());

        // Act
        var result = command.Handles("SING");

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Handles_ShouldReturnTrue_WhenLowercaseInputIsProvided()
    {
        // Arrange
        var command = new SingCommand(new UserInputOutput());

        // Act
        var result = command.Handles("sing");

        // Assert
        Assert.IsTrue(result);
    }
}