using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string grade = Console.ReadLine();
            double discount = 0.0;
            double price = 0.0;
            int nights = days - 1;
            if (typeOfRoom == "room for one person")
            {
                price = 18 * nights;
            }
            else if (typeOfRoom == "apartment")
            {
                if (days < 10)
                {
                    discount = 0.3;
                    price = 25 * nights - ((25 * nights) * discount);
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 0.35;
                    price = 25 * nights - ((25 * nights) * discount);
                }
                else if (days > 15)
                {
                    discount = 0.5;
                    price = 25 * nights - ((25 * nights) * discount);
                }
            }
            else if (typeOfRoom == "president apartment")
            {
                if (days < 10)
                {
                    discount = 0.1;
                    price = 35 * nights - ((35 * nights) * discount);
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 0.15;
                    price = 35 * nights - ((35 * nights) * discount);
                }
                else if (days > 15)
                {
                    discount = 0.20;
                    price = 35 * nights - ((35 * nights) * discount);
                }
            }
            if (grade == "positive")
            {
                price = price + (price * 0.25);
            }
            else if (grade == "negative")
            {
                price = price - (price * 0.1);
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
