//Biruk SImachew
//2/6/2025
namespace The_Magic_Cannon
{
    internal class Program
    {
        public static void Main(string[] args)
        {


            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i}: Fire and Electric");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i}: Fire");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i}: Electric");
                }
                else
                {
                    Console.WriteLine($"{i}: Normal");
                }
            }
        }
    }
}
