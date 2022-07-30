using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfNums = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numOfNums; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
