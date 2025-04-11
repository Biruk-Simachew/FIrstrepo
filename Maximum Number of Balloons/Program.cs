//Biruk Simachew
//4/10/2025
namespace Maximum_Number_of_Balloons
{
    public class Program
    {
        public static int BallonCount(string inputString)
        {
            Dictionary<char,int> letterCount= new Dictionary<char,int>();
            letterCount.Add( 'b', 0 );
            letterCount.Add('a', 0);
            letterCount.Add('l', 0);
            letterCount.Add('o', 0);
            letterCount.Add('n', 0);
            foreach ( char letter in inputString )
            {
                if (letterCount.ContainsKey(letter))
                {
                    letterCount[letter]++;
                }
            }
            
            letterCount['l'] = letterCount['l'] / 2;
            letterCount['o'] = letterCount['o'] / 2;
            int maxBallon = letterCount.Values.Min();
            return maxBallon;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(BallonCount("nlaebolko"));
            Console.WriteLine(BallonCount("loonbalxballpoonballoon"));
        }
    }
}
