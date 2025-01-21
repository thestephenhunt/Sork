using Sork;

public class TestInputOutput : IUserInputOutput
{
    public List<string> Outputs { get; set; } = [];

    public string ReadInput() => "John";

    public string ReadKey() => "";

    public void WriteMessage(string message) => Outputs.Add(message);

    public void WriteMessageLine(string message) => Outputs.Add(message);

    public void WriteNoun(string noun) => Outputs.Add(noun);

    public void WritePrompt(string prompt)
    {
    }
}