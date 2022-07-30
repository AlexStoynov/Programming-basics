using System;

namespace SumOf2Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int  magicNum = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int x1 = start; x1 <= end; x1++)
            {
                for (int x2 = start; x2 <= end; x2++)
                {
                    counter++;
                    int result = x1 + x2;

                    if (result == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({x1} + {x2} = {magicNum})");
                        return;
                    }
                }
            }
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
        }
    }
}
