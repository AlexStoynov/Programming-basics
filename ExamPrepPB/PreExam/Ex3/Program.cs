using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Аржентина   Бразилия    Хърватия    Дания
            //флагчета    3.25 лв.    4.20 лв.    2.75 лв.    3.10 лв.
            //шапки       7.20 лв.    8.50 лв.    6.90 лв.    6.50 лв.
            //плакати     5.10 лв.    5.35 лв.    4.95 лв.    4.80 лв.
            //стикери     1.25 лв.    1.20 лв.    1.10 лв.    0.90 лв.
            string team = Console.ReadLine();
            string souvenir = Console.ReadLine();
            int boughtSouvenirs = int.Parse(Console.ReadLine());
            double fullPrice = 0;
            if (team == "Argentina")
            {
                if (souvenir == "flags")
                {
                    fullPrice = boughtSouvenirs * 3.25;
                }
                else if (souvenir == "caps")
                {
                    fullPrice = boughtSouvenirs * 7.20;
                }
                else if (souvenir == "posters")
                {
                    fullPrice = boughtSouvenirs * 5.10;
                }
                else if (souvenir == "stickers")
                {
                    fullPrice = boughtSouvenirs * 1.25;
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                    return;
                }
            }
            else if (team == "Brazil")
            {
                if (souvenir == "flags")
                {
                    fullPrice = boughtSouvenirs * 4.20;
                }
                else if (souvenir == "caps")
                {
                    fullPrice = boughtSouvenirs * 8.50;
                }
                else if (souvenir == "posters")
                {
                    fullPrice = boughtSouvenirs * 5.35;
                }
                else if (souvenir == "stickers")
                {
                    fullPrice = boughtSouvenirs * 1.20;
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                    return;
                }
            }
            else if (team == "Croatia")
            {
                if (souvenir == "flags")
                {
                    fullPrice = boughtSouvenirs * 2.75;
                }
                else if (souvenir == "caps")
                {
                    fullPrice = boughtSouvenirs * 6.90;
                }
                else if (souvenir == "posters")
                {
                    fullPrice = boughtSouvenirs * 4.95;
                }
                else if (souvenir == "stickers")
                {
                    fullPrice = boughtSouvenirs * 1.10;
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                    return;
                }
            }
            else if (team == "Denmark")
            {
                if (souvenir == "flags")
                {
                    fullPrice = boughtSouvenirs * 3.10;
                }
                else if (souvenir == "caps")
                {
                    fullPrice = boughtSouvenirs * 6.50;
                }
                else if (souvenir == "posters")
                {
                    fullPrice = boughtSouvenirs * 4.80;
                }
                else if (souvenir == "stickers")
                {
                    fullPrice = boughtSouvenirs * 0.90;
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid country!");
                return;
            }
            Console.WriteLine($"Pepi bought {boughtSouvenirs} {souvenir} of {team} for {fullPrice:f2} lv.");
        }
    }
}
