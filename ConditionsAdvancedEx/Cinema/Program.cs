using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double price = 0.0;
            if (type == "Premiere")
            {
                price = 12;
            }
            else if (type == "Normal")
            {
                price = 7.50;
            }
            else if (type == "Discount")
            {
                price = 5;
            }
            double income = rows * colums * price;
            Console.WriteLine($"{income:f2} leva");

        }
    }
}
