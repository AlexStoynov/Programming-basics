using System;

namespace ToyShop
{
    class Program
    {
        static void Main()
        {
            double priceOfHoliday = double.Parse(Console.ReadLine());
            double numOfPuzzles = double.Parse(Console.ReadLine());
            double numOfDolls = double.Parse(Console.ReadLine());
            double numOfBears = double.Parse(Console.ReadLine());
            double numOfMinions = double.Parse(Console.ReadLine());
            double numOfTrucks = double.Parse(Console.ReadLine());
            double numOfToys = numOfBears + numOfDolls + numOfMinions + numOfPuzzles + numOfTrucks;
            double totalIncome = numOfPuzzles * 2.60 + numOfDolls * 3 + numOfBears * 4.10 + numOfMinions * 8.20 + numOfTrucks * 2;
            if (numOfToys >= 50)
            {
                totalIncome = totalIncome - totalIncome * 0.25;
            }

            totalIncome = totalIncome - totalIncome * 0.10;
            if (totalIncome >= priceOfHoliday)
            {
                Console.WriteLine($"Yes! {totalIncome - priceOfHoliday:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceOfHoliday - totalIncome:f2} lv needed.");
            }
        }
    }
}
