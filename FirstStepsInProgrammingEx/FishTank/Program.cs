using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = length * width * height;
            double allLiters = volume * 0.001;
            percent = percent * 0.01;
            double litersNeeded = allLiters * (1 - percent);
            Console.WriteLine(litersNeeded);
        }
    }
}
