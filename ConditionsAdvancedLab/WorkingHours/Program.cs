using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            if (hour >= 10 && hour <= 18)
            {
                switch (dayOfWeek)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        Console.WriteLine("open");
                            break;
                    case "Saturday":
                    case "Sunday":
                        Console.WriteLine("closed");
                        break;
                }
            }
            else if (hour < 10 || hour > 18)
            {
                Console.WriteLine("closed");
            }
        }
    }
}
