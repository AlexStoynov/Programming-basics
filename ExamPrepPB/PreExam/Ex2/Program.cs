using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int processorsNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double hours = workers * days * 8;
            double processorsMade = Math.Floor(hours / 3);
            if (processorsMade < processorsNeeded)
            {
                double losses = (processorsNeeded - processorsMade) * 110.1;
                Console.WriteLine($"Losses: -> {losses:f2} BGN");
            }
            else
            {
                double winnings = (processorsMade - processorsNeeded) * 110.1;
                Console.WriteLine($"Profit: -> {winnings:f2} BGN");
            }

        }
    }
}
