using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfJudges = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double sumOfAllGrades = 0;
            int numOfGrades = 0;
            while (input != "Finish")
            {
                double sumOfGrades = 0;
                for (int i = 1; i <= numOfJudges; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfGrades += grade;
                    sumOfAllGrades += grade;
                    numOfGrades++;
                }
                double average = sumOfGrades / numOfJudges;
                Console.WriteLine($"{input} - {average:f2}.");
                input = Console.ReadLine();
            }
            double finalScore = sumOfAllGrades / numOfGrades;
            Console.WriteLine($"Student's final assessment is {finalScore:f2}.");
        }
    }
}
