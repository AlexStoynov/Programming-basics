using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double stepSum = 0;
            while (input != "Going home")
            {
                int steps = int.Parse(input);
                stepSum += steps;
                if (stepSum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepSum - 10000} steps over the goal!");
                    return;
                }
                input = Console.ReadLine();
            } 
            if (input == "Going home")
            {
                int stepsHome = int.Parse(Console.ReadLine());
                stepSum += stepsHome;
                if (stepSum < 10000)
                {
                    Console.WriteLine($"{10000 - stepSum} more steps to reach goal.");
                }
                else
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepSum - 10000} steps over the goal!");
                }
            }
            
        }
    }
}
