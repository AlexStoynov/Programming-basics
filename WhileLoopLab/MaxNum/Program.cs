using System;

namespace MaxNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxNum = int.MinValue;
            while (input != "Stop")
            {
                int n = int.Parse(input);
                input = Console.ReadLine();
                if (n > maxNum)
                {
                    maxNum = n;
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
