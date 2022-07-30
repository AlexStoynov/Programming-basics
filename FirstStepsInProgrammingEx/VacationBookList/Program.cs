using System;

namespace VacationBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPagesPerBook = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double time = numOfPagesPerBook / pagesPerHour;
            double result = time / days;
            Console.WriteLine(result);
        }
    }
}
