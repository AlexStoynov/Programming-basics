using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double priceForWashingMachine = double.Parse(Console.ReadLine());
            double priceForToys = double.Parse(Console.ReadLine());
            int money = 0;
            int numOfToys = 0;
            int yearsTakenMoney = 0;
            double totalMoneyForBirthdays = 0;
            for (int i = 1; i <= years; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10;
                    totalMoneyForBirthdays += money;
                    yearsTakenMoney += 1;
                }
                else
                {
                    numOfToys += 1;
                }
            }
            double totalPriceForToys = numOfToys * priceForToys;
            double totalMoney = (totalPriceForToys + totalMoneyForBirthdays) - yearsTakenMoney;
            if (totalMoney >= priceForWashingMachine)
            {
                Console.WriteLine($"Yes! {totalMoney - priceForWashingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceForWashingMachine - totalMoney:f2}");
            }
        }
    }
}
