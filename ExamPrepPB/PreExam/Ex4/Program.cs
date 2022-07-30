using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                if (i == s && s % 2 == 0 && s % 3 == 0)
                {
                    break;
                }
                else if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.Write($"{i} ");
                }
                
            }
        }
    }
}
