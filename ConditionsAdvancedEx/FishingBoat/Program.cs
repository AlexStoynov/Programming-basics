using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numOfFisherMen = int.Parse(Console.ReadLine());

            int summerPrice = 4200;
            int springPrice = 3000;
            int winterPrice = 2600;
            int autumnPrice = 4200;
            double totalPrice = 0.0;

            switch (season)
            {
                case "Summer":
                    totalPrice = summerPrice;
                    break;
                case "Spring":
                    totalPrice = springPrice;
                    break;
                case "Winter":
                    totalPrice = winterPrice;
                    break;
                case "Autumn":
                    totalPrice = autumnPrice;
                    break;
            }
            if (numOfFisherMen <= 6)
            {
                totalPrice -= totalPrice * 0.10;
            }
            else if (numOfFisherMen >= 7 && numOfFisherMen <= 11)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (numOfFisherMen >= 12)
            {
                totalPrice -= totalPrice * 0.25;
            }
            if (numOfFisherMen % 2 == 0 && season != "Autumn")
            {
                totalPrice -= totalPrice * 0.05;
            }
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva.");
            }
        }
    }
}
