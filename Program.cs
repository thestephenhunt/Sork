public class Program
{
    public static void Main(string[] args)
    {
        do
        {
            Console.Write(" > ");
            string input = Console.ReadLine();
            input = input.ToLower();
            input = input.Trim();
            if (input == "lol") { Console.WriteLine("You laugh out loud"); }
            else if (input == "dance") { Console.WriteLine("You dance awkwardly"); }
            else if (input == "sing") { Console.WriteLine("You sing off key"); }
            else if (input == "whistle") { Console.WriteLine("You whistle loudly"); }
            else if (input == "exit") { break;}
            else { Console.WriteLine("Huh?"); }
        } while (true);
    }
}