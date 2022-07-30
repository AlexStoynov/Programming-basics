using System;

namespace SumSecs
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalTime = 0;
            totalTime += int.Parse(Console.ReadLine());
            totalTime += int.Parse(Console.ReadLine());
            totalTime += int.Parse(Console.ReadLine());
            int minutes = 0;
            int seconds = 0;

            if (totalTime >= 120)
            {
                minutes = 2;
                seconds = totalTime - 120;
            }
            else if (totalTime >=60)
            {
                minutes = 1;
                seconds = totalTime - 60;
            }
            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}
