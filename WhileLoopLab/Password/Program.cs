using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = Console.ReadLine();
            string currPass = " ";
            for (int i = 0; i < 3; i++)
            {
                currPass = Console.ReadLine();
                if (currPass == pass)
                {
                    Console.WriteLine($"Welcome {name}!");
                    break;
                }
            }
            Console.WriteLine("Wrong password");
        }
    }
}
