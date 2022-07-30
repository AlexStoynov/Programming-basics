using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int totalTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;
            int studentTickets = 0;
            while (movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());

                int ticketCounter = 0;
                string ticketType = Console.ReadLine();
                while (ticketType != "End")
                {
                    ticketCounter++;
                    switch (ticketType)
                    {
                        case "standard":
                            standardTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;
                        case "student":
                            studentTickets++;
                            break;
                    }
                    if (ticketCounter == availableSeats)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }
                totalTickets += ticketCounter;

                double percentfull = ticketCounter * 1.0 / availableSeats * 100;
                Console.WriteLine($"{movie} - {percentfull:f2}% full.");
                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");

            double standardTicketPercent = standardTickets * 1.0 / totalTickets * 100;
            double kidTicketPercent = kidTickets * 1.0 / totalTickets * 100;
            double studentTicketPercent = studentTickets * 1.0 / totalTickets * 100;

            Console.WriteLine($"{studentTicketPercent:f2}% student tickets.");
            Console.WriteLine($"{standardTicketPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketPercent:f2}% kids tickets.");
        }
    }
}
