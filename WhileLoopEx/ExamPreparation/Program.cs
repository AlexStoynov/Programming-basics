using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfBadGradesAllowed = int.Parse(Console.ReadLine());
            int numOfGoodGrades = 0;
            int numOfBadGrades = 0;
            double sumGrade = 0;
            int numOfSolvedProblems = 0;
            string lastProblem = " ";
            string problem = Console.ReadLine();
            while (problem != "Enough")
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    numOfBadGrades++;
                }
                if (numOfBadGrades >= numOfBadGradesAllowed)
                {
                    break;
                }
                numOfSolvedProblems++;
                sumGrade += grade;
                lastProblem = problem;

                problem = Console.ReadLine();
            }
                if (numOfBadGrades >= numOfBadGradesAllowed)
                {
                    Console.WriteLine($"You need a break, {numOfBadGrades} poor grades.");
                }
                else
                {
                    double averageGrade = sumGrade / numOfSolvedProblems;
                    Console.WriteLine($"Average score: {averageGrade:f2}");
                    Console.WriteLine($"Number of problems: {numOfSolvedProblems}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                }
        }
    }
}
