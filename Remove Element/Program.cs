//Biruk Simachew
//4/3/25
namespace Remove_Element
{
    public class Program
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int k = 0; // Index to place the next non-val element

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }
        static void Main(string[] args)
        {
            int[] nums1 = { 3, 2, 2, 3 };
            int val1 = 3;
            int k1 = RemoveElement(nums1, val1);
            Console.WriteLine($"k = {k1}, nums = [{string.Join(", ", nums1[..k1])}]");
        }
    }
}
