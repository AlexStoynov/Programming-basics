using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());
            double avarageGoldPerDay = 0;
            double goldNeeded = 0;
            double goldSum = 0;
            for (int i = 1; i <= locations; i++)
            {
                int expectedAvarageGoldPerDay = int.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                for (int j = 1; j <= days; j++)
                {
                    int goldFor1Day = int.Parse(Console.ReadLine());
                    goldSum += goldFor1Day;
                }
                avarageGoldPerDay = goldSum / days;
                if (avarageGoldPerDay < expectedAvarageGoldPerDay)
                {
                    Console.WriteLine($"You need {expectedAvarageGoldPerDay - avarageGoldPerDay:f2} gold.");
                }
                else
                {
                    Console.WriteLine($"Good job! Average gold per day: {avarageGoldPerDay:f2}.");
                }
                goldSum = 0;
            }
            
        }
    }
}
