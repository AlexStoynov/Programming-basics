using System;

namespace CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            int priceForTicket = 0;

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    priceForTicket = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    priceForTicket = 14;
                    break;
                case "Saturday":
                case "Sunday":
                    priceForTicket = 16;
                    break;
            }

            Console.WriteLine(priceForTicket);
        }
    }
}
