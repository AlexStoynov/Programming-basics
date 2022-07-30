using System;

namespace GodzillaVsKingKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceCostumePerStatist = double.Parse(Console.ReadLine());
            double discount = 0.0;
            double priceForCostumes = priceCostumePerStatist * statists;
            double decor = budget * 0.10;
            double fullPrice = 0.0;
            if (statists > 150)
            {
                discount = priceForCostumes * 0.1;
                double fullPriceForCostumes = priceForCostumes - discount;
                fullPrice = fullPriceForCostumes + decor;
            }
            else
            {

                fullPrice = priceForCostumes + decor;

            }

            if (budget >= fullPrice)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - fullPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(fullPrice - budget):f2} leva more.");
            }
        }
    }
}
