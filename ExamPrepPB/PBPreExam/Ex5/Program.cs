using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int kidCount = 0;
            int adultCount = 0;
            int moneyForToys = 0;
            int moneyForSweaters = 0;
            while (input != "Christmas")
            {
                int currAge = Int32.Parse(input);
                if (currAge <= 16)
                {
                    kidCount++;
                    moneyForToys += 5;
                }
                else
                {
                    adultCount++;
                    moneyForSweaters += 15;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Number of adults: {adultCount}");
            Console.WriteLine($"Number of kids: {kidCount}");
            Console.WriteLine($"Money for toys: {moneyForToys}");
            Console.WriteLine($"Money for sweaters: {moneyForSweaters}");
        }
    }
}
