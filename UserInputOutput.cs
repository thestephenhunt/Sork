public class UserInputOutput
{
    public void WritePrompt(string prompt) 
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(prompt);
        Console.ResetColor();
    }
    public void WriteMessage(string message) 
    {
        Console.Write(message);
    }
    public void WriteNoun(string noun) 
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(noun);
        Console.ResetColor();
    }
    public void WriteMessageLine(string message) 
    {
        Console.WriteLine(message);
    }
    public string ReadInput() 
    {
        return Console.ReadLine().Trim();
    }
    public string ReadKey() 
    {
        return Console.ReadKey().KeyChar.ToString();
    }
}