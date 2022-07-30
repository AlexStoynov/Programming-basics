using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double cakePrice = rent * 0.2;
            double drinksPrice = cakePrice - cakePrice * 0.45;
            double animatorPrice = rent / 3;
            double fullPrice = rent + cakePrice + drinksPrice + animatorPrice;
            Console.WriteLine(fullPrice);
        }
    }
}
