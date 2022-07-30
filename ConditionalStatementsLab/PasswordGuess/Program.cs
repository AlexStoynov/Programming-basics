using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string enteredPassword = Console.ReadLine();

            if (enteredPassword == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
