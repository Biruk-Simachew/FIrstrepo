//Biruk Simachew
//4/3/25
namespace Sort_Array_By_Parity
{
    public class Program
    {
        public static void Sort(int[] nums)
        {
            int temp;
            int num_of_even = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] % 2 == 0)
                {
                    temp = nums[num_of_even];
                    nums[num_of_even] = nums[i];
                    nums[i] = temp;
                    num_of_even++;

                } }
            

        }
        static void Main(string[] args)
        {
            int[] a = { 0 };
            Sort(a);
            Console.WriteLine(string.Join(',',a));
        }
    }
}
