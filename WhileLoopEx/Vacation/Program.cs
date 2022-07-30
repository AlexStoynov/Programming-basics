using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int spendingCounter = 0;
            int daysCounter = 0;
            while (spendingCounter < 5)
            {
                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                if (input == "spend")
                {
                    if (money > ownedMoney)
                    {
                        ownedMoney = 0;
                    }
                    else
                    {
                        ownedMoney -= money;
                    }
                    spendingCounter++;
                    daysCounter++;
                }
                else
                {
                    spendingCounter = 0;
                    daysCounter++;
                    ownedMoney += money;
                }
                if (ownedMoney >= moneyNeeded)
                {
                    Console.WriteLine($"You saved the money for {daysCounter} days.");
                    break;
                }
            }
            if (spendingCounter >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }

        }
    }
}
