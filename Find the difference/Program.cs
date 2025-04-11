//Biruk Simachew
//4/10/2025
namespace Find_the_difference
{
    internal class Program
    {

        public static char FindTheDifference(string s, string t)
        {
            foreach (char letter in t)
            {
                if (!s.Contains(letter)){
                    return letter;
                }
            }
            return ' ';
        } 
        static void Main(string[] args)
        {
            Console.WriteLine(FindTheDifference("abc","abcd"));
        }
    }
}
