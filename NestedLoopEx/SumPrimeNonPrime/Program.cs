using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int primeSum = 0;
            int nonprimeSum = 0;
            while (command != "stop")
            {
                int n = int.Parse(command);
                if (n < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int count = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        if (n % i == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 2)
                    {
                        primeSum += n;
                    }
                    else
                    {
                        nonprimeSum += n;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonprimeSum}");
        }
    }
}
