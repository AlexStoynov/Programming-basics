using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int cakePieces = length * width;
            while (cakePieces >= 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                int cake = int.Parse(input);
                cakePieces -= cake;
            }

            if (cakePieces >= 0)
            {
                Console.WriteLine($"{cakePieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
            }
        }
    }
}
