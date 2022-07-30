using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalMoney = 0.0;
            while (input != "NoMoreMoney")
            {
                double moneyAdded = double.Parse(input);
                if (moneyAdded < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {moneyAdded:f2}");
                totalMoney += double.Parse(input);
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {totalMoney:f2}");
        }
    }
}
