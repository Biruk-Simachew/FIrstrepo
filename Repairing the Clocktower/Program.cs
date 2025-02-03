//Biruk Simachew
//1/30/2025
//Repairing the Clocktower
namespace Repairing_the_Clocktower
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Tick");
            }
            else
            {
                Console.WriteLine("Tock");
            }
        }
    }
}
