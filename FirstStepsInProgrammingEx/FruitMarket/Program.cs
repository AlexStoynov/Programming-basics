using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfStrawberries = double.Parse(Console.ReadLine());
            double quantityOfBananas = double.Parse(Console.ReadLine());
            double quantityOfOranges = double.Parse(Console.ReadLine());
            double quantityOfRaspberries = double.Parse(Console.ReadLine());
            double quantityOfStrawberries = double.Parse(Console.ReadLine());

            double priceOfRaspberries = priceOfStrawberries / 2;
            double priceOfOranges = priceOfRaspberries - (priceOfRaspberries * 0.4);
            double priceOfBananas = priceOfRaspberries - (priceOfRaspberries * 0.8);

            double fullPriceOfStrawberries = quantityOfStrawberries * priceOfStrawberries;
            double fullPriceOfBananas = quantityOfBananas * priceOfBananas;
            double fullPriceOfOranges = quantityOfOranges * priceOfOranges;
            double fullPriceOfRaspberries = quantityOfRaspberries * priceOfRaspberries;
            double fullPrice = fullPriceOfStrawberries + fullPriceOfBananas + fullPriceOfOranges + fullPriceOfRaspberries;
            Console.WriteLine($"{fullPrice:f2}");
        }
    }
}
