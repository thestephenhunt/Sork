using Sork.Commands;
using Sork.World;

namespace Sork.Tests;

[TestClass]
public class DanceCommandTests
{
    [TestMethod]
    public void Handle_ShouldOutputMessage()
    {
        // Arrange
        var io = new TestInputOutput();
        var command = new DanceCommand(io);
        var gameState = GameState.Create(io);

        // Act  
        command.Execute("dance", gameState);

        // Assert
        Assert.AreEqual("You", io.Outputs[0]);
        Assert.AreEqual(" dance awkwardly.", io.Outputs.Last());
    }

    [TestMethod]
    public void Handle_ShouldReturnTrue_WhenCapitalizedInputIsProvided()
    {
        // Arrange
        var command = new DanceCommand(new UserInputOutput());

        // Act  
        var result = command.Handles("DANCE");

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Handles_ShoudReturnTrue_WhenLowercaseInputIsProvided()
    {
        // Arrange
        var command = new DanceCommand(new UserInputOutput());

        // Act
        var result = command.Handles("dance");

        // Assert
        Assert.IsTrue(result);
    }
}