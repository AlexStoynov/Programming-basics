using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double socialScholarship = Math.Floor(minimalSalary * 0.35);
            double gradeScholarship = Math.Floor(grade * 25);

            if (grade >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {gradeScholarship} BGN");
            }
            else if (grade >= 4.50)
            {
                if (money < minimalSalary)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            

        }
    }
}
