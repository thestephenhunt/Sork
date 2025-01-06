using Sork.Commands;

namespace Sork;

public class Program
{
    public static void Main(string[] args)
    {
        UserInputOutput io = new UserInputOutput();
        ICommand lol = new LaughCommand(io);
        ICommand exit = new ExitCommand();
        ICommand dance = new DanceCommand(io);
        ICommand sing = new SingCommand(io);
        ICommand whistle = new WhistleCommand(io);
        List<ICommand> commands = new List<ICommand> { lol, exit, dance, sing, whistle };

        do
        {
            io.WritePrompt(" > ");
            string input = io.ReadInput();
            input = input.ToLower();
            input = input.Trim();

            var result = new CommandResult { RequestExit = false, IsHandled = false };
            var handled = false;
            foreach (var command in commands)
            {
                if (command.Handles(input))
                {
                    handled = true;
                    result = command.Execute();
                    if (result.RequestExit)
                    {
                        break;
                    }
                }
            }
            if (result.RequestExit) 
            {
                break;
            }
            if (!handled)
            {
                io.WriteMessageLine("Huh?");
            }
        } while (true);
    }
}

public class UserInputOutput
{
    public void WritePrompt(string prompt) 
    {
        Console.Write(prompt);
    }
    public void WriteMessage(string message) 
    {
        Console.Write(message);
    }
    public void WriteNoun(string noun) 
    {
        Console.Write(noun);
    }
    public void WriteMessageLine(string message) 
    {
        Console.WriteLine(message);
    }
    public string ReadInput() 
    {
        return Console.ReadLine();
    }
    public string ReadKey() 
    {
        return Console.ReadKey().KeyChar.ToString();
    }
}