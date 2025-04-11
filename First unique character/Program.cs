//Biruk Simachew
//4/10/2025
namespace First_unique_character
{
    public class Program
    {
        public static int FindIndex(string text)
        {
            Dictionary<char,int> letterCount = new Dictionary<char,int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (letterCount.ContainsKey(text[i]))
                {
                    letterCount[text[i]]++;

                }
                else
                {
                    letterCount.Add(text[i], 0);
                } }
            for(int i = 0; i < text.Length; i++)
                {
                    if (letterCount[text[i] ]== 0)
                    {
                        return i;
                    }
                }
            
            return -1;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindIndex("aabb"));
        }
    }
}
