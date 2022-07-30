using System;

namespace EvenOddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;
            for (int i = 0; i < num; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += nums;
                }
                else
                {
                    odd += nums;
                }
            }
            if (even == odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(even - odd)}");
            }
        }
    }
}
