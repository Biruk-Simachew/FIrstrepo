//Biruk Simachew
//4/3/25
namespace twosum
{
    public class Program
    {
        public static  int[] findIndex(int[] nums, int target)
        {
            
            for (int i = 0; i < nums.Length ; i++) {
                for (int j = i + 1; j < nums.Length ; j++) {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int []{ i,j};
                        
                    }
                } }
            return new int[] {-1};

        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            int target = 10;
            
            Console.WriteLine(string.Join(',',findIndex(nums,target)));
        }
    }
}
