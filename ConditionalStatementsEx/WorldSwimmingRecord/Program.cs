using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeFor1Meter = double.Parse(Console.ReadLine());

            double timeHeNeeds = distance * timeFor1Meter;
            double delay = Math.Floor(distance / 15) * 12.5;
            double fullTime = delay + timeHeNeeds;
            if (record > fullTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {fullTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(fullTime - record):f2} seconds slower.");
            }
        }
    }
}
