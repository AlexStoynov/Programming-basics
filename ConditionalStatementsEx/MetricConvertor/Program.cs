using System;

namespace MetricConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            if (input == "cm")
            {
                num /= 100;
            }
            else if (input == "mm")
            {
                num /= 1000;
            }
            if (output == "cm")
            {
                num *= 100;
            }
            else if (output == "mm")
            {
                num *= 1000;
            }

            Console.WriteLine($"{num:f3}");
        }
    }
}
