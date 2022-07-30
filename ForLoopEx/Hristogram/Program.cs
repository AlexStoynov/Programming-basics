using System;

namespace Hristogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1++;
                }
                else if (number < 400)
                {
                    p2++;
                }
                else if (number < 600)
                {
                    p3++;
                }
                else if (number < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            Console.WriteLine($"{1.0 * p1 / n * 100:f2}%");
            Console.WriteLine($"{1.0 * p2 / n * 100:f2}%");
            Console.WriteLine($"{1.0 * p3 / n * 100:f2}%");
            Console.WriteLine($"{1.0 * p4 / n * 100:f2}%");
            Console.WriteLine($"{1.0 * p5 / n * 100:f2}%");
        }
    }
}
