//Biruk Simachew
//1/30/2025
//The Dominion of Kings
namespace The_Dominion_of_Kings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of provinces:");
            int provinces = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of duchies:");
            int duchies = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of estates:");
            int estates = Convert.ToInt32(Console.ReadLine());

            int totalScore = (provinces * 6) + (duchies * 3) + (estates * 1);

            Console.WriteLine($"The total score of the kingdom is: {totalScore}");
        }
    }
}
