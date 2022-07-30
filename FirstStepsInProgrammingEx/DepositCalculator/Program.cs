using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double interestPercent = double.Parse(Console.ReadLine());
            double interestSum = depositSum * interestPercent * 0.01;
            double sumOfInterest = interestSum / 12;
            double money = depositSum + (term * sumOfInterest);
            Console.WriteLine(money);
        }
    }
}
