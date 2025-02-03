//Biruk Simachew
//1/30/2025
//The Defense of Consolas
namespace The_Defense_of_Consolas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Defense of Consolas";

            Console.WriteLine("Target Row?");
            int targetRow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Target Column?");
            int targetColumn = Convert.ToInt32(Console.ReadLine());

            int leftColumn = targetColumn - 1;
            int rightColumn = targetColumn + 1;
            int topRow = targetRow - 1;
            int bottomRow = targetRow + 1;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Deploy to:");
            Console.WriteLine($"({targetRow}, {leftColumn})");
            Console.WriteLine($"({topRow}, {targetColumn})");
            Console.WriteLine($"({targetRow}, {rightColumn})");
            Console.WriteLine($"({bottomRow}, {targetColumn})");
            Console.ResetColor();

            Console.Beep();
        }
    }
}
