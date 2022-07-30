using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sellings = double.Parse(Console.ReadLine());
            double commission = 0.0;
            if (city == "Sofia")
            {
                if (sellings >= 0 && sellings <= 500)
                {
                    commission = sellings * 0.05;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sellings > 500 && sellings <= 1000)
                {
                    commission = sellings * 0.07;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sellings > 1000 && sellings <= 10000)
                {
                    commission = sellings * 0.08;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sellings > 10000)
                {
                    commission = sellings * 0.12;
                    Console.WriteLine($"{commission:f2}");
                }
            }
            else if (city == "Varna")
            {
                if (sellings >= 0 && sellings <= 500)
                {
                    commission = sellings * 0.045;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sellings > 500 && sellings <= 1000)
                {
                    commission = sellings * 0.075;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sellings > 1000 && sellings <= 10000)
                {
                    commission = sellings * 0.10;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sellings > 10000)
                {
                    commission = sellings * 0.13;
                    Console.WriteLine($"{commission:f2}");
                }
            }
            else if (city == "Plovdiv")
            {
                if (sellings >= 0 && sellings <= 500)
                {
                    commission = sellings * 0.055;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sellings > 500 && sellings <= 1000)
                {
                    commission = sellings * 0.08;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sellings > 1000 && sellings <= 10000)
                {
                    commission = sellings * 0.12;
                    Console.WriteLine($"{commission:f2}");
                }
                else if (sellings > 10000)
                {
                    commission = sellings * 0.145;
                    Console.WriteLine($"{commission:f2}");
                }
            }
            if (sellings < 0)
            {
                Console.WriteLine("error");
            }
            else if (city != "Sofia" && city != "Varna" && city != "Plovdiv")
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
