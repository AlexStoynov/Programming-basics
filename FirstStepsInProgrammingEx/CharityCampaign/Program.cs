using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            const double cakePrice = 45;
            const double wafflePrice = 5.80;
            const double pancakePrice = 3.20;

            int numOfDays = int.Parse(Console.ReadLine());
            int numOfBakers = int.Parse(Console.ReadLine());
            int numOfCakes = int.Parse(Console.ReadLine());
            int numOfWffles = int.Parse(Console.ReadLine());
            int numOfPancakes = int.Parse(Console.ReadLine());

            double cakes = numOfCakes * cakePrice;
            double waffles = numOfWffles * wafflePrice;
            double pancakes = numOfPancakes * pancakePrice;
            double priceForOneDay = (cakes + waffles + pancakes) * numOfBakers;
            double moneyCollected = priceForOneDay * numOfDays;
            double moneyAfterCost = moneyCollected - moneyCollected / 8;
            Console.WriteLine(moneyAfterCost);
        }
    }
}
