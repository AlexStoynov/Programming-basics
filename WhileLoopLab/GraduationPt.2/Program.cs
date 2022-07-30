using System;

namespace GraduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentClass = 0;
            int failed = 0;
            double annualGrade = 0;
            while (currentClass < 12)
            {
                double currenGrade = double.Parse(Console.ReadLine());
                if (currenGrade < 4)
                {
                    failed++;
                }
                if (failed >= 2)
                {
                    Console.WriteLine($"{name} has been excluded at {currentClass} grade");
                    break;

                }
                annualGrade += currenGrade;
                currentClass++;
            }
            if (failed < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {annualGrade / currentClass:f2}");
            }
        }
    }
}
