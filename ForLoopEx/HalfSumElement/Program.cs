using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > maxNum)
                {
                    maxNum = num;
                }
                sum += num;
            }
            int totalSum = sum - maxNum;
            if (totalSum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {totalSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(totalSum - maxNum)}");
            }
        }
    }
}
