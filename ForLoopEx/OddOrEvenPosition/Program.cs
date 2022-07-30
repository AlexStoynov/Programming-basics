using System;

namespace OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            double maxEvenNum = int.MinValue;
            double minEvenNum = int.MaxValue;
            double evenSum = 0;
            double maxOddNum = int.MinValue;
            double minOddNum = int.MaxValue;
            double oddSum = 0;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (minEvenNum > num)
                    {
                        minEvenNum = num;
                    }
                    if (maxEvenNum < num)
                    {
                        maxEvenNum = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (maxOddNum < num)
                    {
                        maxOddNum = num;
                    }
                    if (minOddNum > num)
                    {
                        minOddNum = num;
                    }
                }
                
            }
            if (oddSum != 0)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={minOddNum:f2},");
                Console.WriteLine($"OddMax={maxOddNum:f2},");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            if (evenSum != 0)
            {
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={minEvenNum:f2},");
                Console.WriteLine($"EvenMax={maxEvenNum:f2}");
            }
            else
            {
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
