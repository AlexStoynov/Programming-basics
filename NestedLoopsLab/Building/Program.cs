using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFloors = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());
            for (int floor = totalFloors; floor >= 1; floor--)
            {
                for (int j = 0; j < room; j++)
                {
                    if (floor == totalFloors)
                    {
                        Console.Write($"L{floor}{j} ");
                    }
                    else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{floor}{j} ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
