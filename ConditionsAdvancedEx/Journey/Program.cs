using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double discount = 0.0;
            double remainingMoney = 0.0;
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    discount = budget - (budget * 0.3);
                    remainingMoney = budget - discount;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {remainingMoney:f2}");
                }
                else if (season == "winter")
                {
                    discount = budget - (budget * 0.7);
                    remainingMoney = budget - discount;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {remainingMoney:f2}");
                }
            }
            else if (budget <= 1000 && budget > 100)
            {
                if (season == "summer")
                {
                    discount = budget - (budget * 0.4);
                    remainingMoney = budget - discount;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {remainingMoney:f2}");
                }
                else if (season == "winter")
                {
                    discount = budget - (budget * 0.8);
                    remainingMoney = budget - discount;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {remainingMoney:f2}");
                }
            }
            else
            {
                discount = budget - (budget * 0.9);
                remainingMoney = budget - discount;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {remainingMoney:f2}");
            }
        }
    }
}
