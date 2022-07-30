using System;

namespace MaxNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minNum = int.MaxValue;
            while (input != "Stop")
            {
                int n = int.Parse(input);
                input = Console.ReadLine();
                if (n < minNum)
                {
                    minNum = n;
                }
            }
            Console.WriteLine(minNum);
        }
    }
}
