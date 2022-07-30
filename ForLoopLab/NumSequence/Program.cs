using System;

namespace NumSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfNums = int.Parse(Console.ReadLine());
            int minNum = int.MaxValue;
            int maxNum = int.MinValue;
            for (int i = 0; i < numOfNums; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > maxNum)
                {
                     maxNum = num;
                }
                if (num < minNum)
                {
                    minNum = num;
                }
            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
