using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            double bonusBonus = 0.0;
            if (num <= 100)
            {
                bonus = 5;
            }
            else if (num > 100 && num < 1000)
            {
                bonus = num * 0.20;
            }
            else if (num > 1000)
            {
                bonus = num * 0.10;
            }
            if (num % 2 == 0)
            {
                bonusBonus = bonus +1;
                bonus = bonusBonus;
            }
            else if (num % 5 == 0)
            {
                bonusBonus = bonus + 2;
                bonus = bonusBonus;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);
        }
    }
}
