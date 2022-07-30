using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsGoingHome = int.Parse(Console.ReadLine());
            int weekendsInSofia = 48 - weekendsGoingHome;
            double saturdayGamesInSofia = weekendsInSofia * 3.0 / 4.0;
            double gamesOnHolidays = holidays * 2.0 / 3.0;
            double totalPlay = saturdayGamesInSofia + gamesOnHolidays + weekendsGoingHome;
            if (typeOfYear == "leap")
            {
                totalPlay *= 1.15;
                Console.WriteLine(Math.Floor(totalPlay));
            }
            else if (typeOfYear == "normal")
            {
                Console.WriteLine(Math.Floor(totalPlay));
            }
        }
    }
}
