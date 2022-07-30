using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string typeOfFlower = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceForFlowers = 0.0;

            switch (typeOfFlower)
            {
                case "Roses":
                    if (numOfFlowers > 80)
                    {
                        priceForFlowers = numOfFlowers * 5;
                        priceForFlowers -= priceForFlowers * 0.10;
                    }
                    else
                    {
                        priceForFlowers = numOfFlowers * 5;
                    }
                    break;
                case "Dahlias":
                    if (numOfFlowers > 90)
                    {
                        priceForFlowers = numOfFlowers * 3.80;
                        priceForFlowers -= priceForFlowers * 0.15;
                    }
                    else
                    {
                        priceForFlowers = numOfFlowers * 3.80;
                    }
                    break;
                case "Tulips":
                    if (numOfFlowers > 80)
                    {
                        priceForFlowers = numOfFlowers * 2.80;
                        priceForFlowers -= priceForFlowers * 0.15;
                    }
                    else
                    {
                        priceForFlowers = numOfFlowers * 2.80;

                    }
                    break;
                case "Narcissus":
                    if (numOfFlowers < 120)
                    {
                        priceForFlowers = numOfFlowers * 3;
                        priceForFlowers += priceForFlowers * 0.15;
                    }
                    else
                    {
                        priceForFlowers = numOfFlowers * 3;
                    }
                    break;
                case "Gladiolus":
                    if (numOfFlowers < 80)
                    {
                        priceForFlowers = numOfFlowers * 2.50;
                        priceForFlowers += priceForFlowers * 0.20;
                    }
                    else
                    {
                        priceForFlowers = numOfFlowers * 2.50;
                    }
                    break;
            }
            if (priceForFlowers <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {typeOfFlower} and {budget - priceForFlowers:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {priceForFlowers - budget:f2} leva more.");
            }
        }
    }
}
