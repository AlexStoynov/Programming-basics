using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            //  четем входните данни
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            // изчисляваме свободното пространство
            int freespace = width * length * height;
            // използваме while цикъл
            string input = Console.ReadLine();
            while (input != "Done")
            {
                int boxSize = int.Parse(input);
                freespace -= boxSize;
                // поверяваме дали има още пространство
                if (freespace <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freespace)} Cubic meters more.");
                    isSpaceEnough = false;
                    break;
                }
                input = Console.ReadLine();
            }
            if ()
            {

            }
                Console.WriteLine($"{freespace} Cubic meters left.");
        }
    }
}
