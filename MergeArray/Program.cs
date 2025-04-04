//Biruk Simachew
//4/3/2025
namespace MergeArray
{
    public class Program
    {
        public static void MergeArray(int[] a, int[] b,int n, int m)
        {
            int c = n + m;
            int temp;
            foreach (int i in b)
            {
                a[n] = i;
                n++;
            }
            for (int i = 0; i < c; i++)
            {
                for(int j = i+1; j < c; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
                
        }

        static void Main(string[] args)
        {
            int[] a = new int[] { 4, 7, 8 ,0,0,0};
            int[]b=new int[] { 4, 9, 2 };
            int n = 3;
            int m = 3;
            MergeArray(a, b, n, m);
            Console.WriteLine(string.Join(',',a));
        }
    }
}
