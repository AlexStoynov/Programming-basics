using System;

namespace NumInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            if (num != 0)
            {
                if (num >= -100 && num <= 100)
                {
                    Console.WriteLine("Yes");
                }

                else
                {
                    Console.WriteLine("No");
                }

            }

            if (num == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
