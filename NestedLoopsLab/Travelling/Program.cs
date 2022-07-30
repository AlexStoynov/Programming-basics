using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());
                double moneySaved = 0;
                while (moneySaved < minBudget)
                {
                    moneySaved += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
