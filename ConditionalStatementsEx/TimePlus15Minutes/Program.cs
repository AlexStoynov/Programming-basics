using System;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes > 59 && hours <+ 23)
            {
                hours += 1;
                minutes /= 60;
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else if (hours >= 23)
            {
                hours = 0;
                minutes /= 60;
                Console.WriteLine($"{hours}:{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}
