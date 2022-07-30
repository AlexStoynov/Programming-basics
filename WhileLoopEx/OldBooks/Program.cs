using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string currBook = Console.ReadLine();
            int counter = 0;
            while (currBook != "No More Books")
            {
                if (currBook == book)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    return;
                }
                counter++;
                currBook = Console.ReadLine();
            }
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {counter} books.");
        }
    }
}
