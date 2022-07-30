using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            string currentTab = " ";
            for (int i = 0; i < tabs; i++)
            {
                currentTab = Console.ReadLine();

                if (currentTab == "Facebook")
                {
                    salary -= 150;
                }
                if (currentTab == "Instagram")
                {
                    salary -= 100;
                }
                if (currentTab == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
