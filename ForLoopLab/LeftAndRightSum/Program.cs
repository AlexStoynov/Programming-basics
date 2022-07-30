using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfNums = int.Parse(Console.ReadLine());
            double leftSum = 0;
            double rightSum = 0;
            for (int i = 0; i < numOfNums; i++)
            {
                leftSum += int.Parse(Console.ReadLine()); ;
            }

            for (int i = 0; i < numOfNums; i++)
            {
                rightSum += int.Parse(Console.ReadLine()); ;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
