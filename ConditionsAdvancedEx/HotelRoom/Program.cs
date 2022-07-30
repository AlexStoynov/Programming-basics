using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceApartment = 0.0;
            double priceStudio = 0.0;
            double fullPriceStudio = 0.0;
            double fullPriceApartment = 0.0;
            if (month == "May" || month == "October")
            {
                
                priceStudio = 50;
                priceApartment = 65;
                if (nights > 7 && nights <= 14)
                {
                    priceStudio -= priceStudio * 0.05;
                }
                else if (nights > 14)
                {
                    priceStudio -= priceStudio * 0.3;
                }
                if (nights >= 14)
                {
                    priceApartment -= priceApartment * 0.1;
                }
                fullPriceStudio = priceStudio * nights;
                fullPriceApartment = priceApartment * nights;
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 75.20;
                priceApartment = 68.70;
                if (nights > 14)
                {
                    priceStudio -= priceStudio * 0.2;
                }
                if (nights > 14)
                {
                    priceApartment -= priceApartment * 0.1;
                }
                fullPriceStudio = priceStudio * nights;
                fullPriceApartment = priceApartment * nights;
            }
            else if (month == "July" || month == "August")
            {
                priceStudio = 76;
                priceApartment = 77;
                if (nights > 14)
                {
                    priceApartment -= priceApartment * 0.1;
                }
                fullPriceStudio = priceStudio * nights;
                fullPriceApartment = priceApartment * nights;
            }
            Console.WriteLine($"Apartment: {fullPriceApartment:f2} lv.");
            Console.WriteLine($"Studio: {fullPriceStudio:f2} lv.");
        }
    }
}
