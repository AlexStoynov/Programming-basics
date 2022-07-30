using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double fruitFullPrice = 0.0;
            double fruitPrice = 0.0;
            if (fruit == "apple")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        fruitPrice = 1.20;
                        fruitFullPrice = fruitPrice * quantity;
                        Console.WriteLine($"{fruitFullPrice:f2}");
                        break;
                    case "Saturday":
                    case "Sunday":
                        fruitPrice = 1.25;
                        fruitFullPrice = fruitPrice * quantity;
                        Console.WriteLine($"{fruitFullPrice:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "banana")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        fruitPrice = 2.50;
                        fruitFullPrice = fruitPrice * quantity;
                        Console.WriteLine($"{fruitFullPrice:f2}");
                        break;

                    case "Saturday":
                    case "Sunday":
                        fruitPrice = 2.70;
                        fruitFullPrice = fruitPrice * quantity;
                        Console.WriteLine($"{fruitFullPrice:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "orange")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        fruitPrice = 0.85;
                        fruitFullPrice = fruitPrice * quantity;
                        Console.WriteLine($"{fruitFullPrice:f2}");
                        break;
                    case "Saturday":
                    case "Sunday":
                        fruitPrice = 0.90;
                        fruitFullPrice = fruitPrice * quantity;
                        Console.WriteLine($"{fruitFullPrice:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "grapefruit")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        fruitPrice = 1.45;
                        fruitFullPrice = fruitPrice * quantity;
                        Console.WriteLine($"{fruitFullPrice:f2}");
                        break;
                    case "Saturday":
                    case "Sunday":
                        fruitPrice = 1.60;
                        fruitFullPrice = fruitPrice * quantity;
                        Console.WriteLine($"{fruitFullPrice:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "kiwi")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        fruitPrice = 2.70;
                        fruitFullPrice = fruitPrice * quantity;
                        Console.WriteLine($"{fruitFullPrice:f2}");
                        break;
                    case "Saturday":
                    case "Sunday":
                        fruitPrice = 3.0;
                        fruitFullPrice = fruitPrice * quantity;
                        Console.WriteLine($"{fruitFullPrice:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
             else if (fruit == "pineapple")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        fruitPrice = 5.50;
                        fruitFullPrice = fruitPrice * quantity;
                        Console.WriteLine($"{fruitFullPrice:f2}");
                        break;
                    case "Saturday":
                    case "Sunday":
                        fruitPrice = 5.60;
                        fruitFullPrice = fruitPrice * quantity;
                        Console.WriteLine($"{fruitFullPrice:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "grapes")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        fruitPrice = 3.85;
                        fruitFullPrice = fruitPrice * quantity;
                        Console.WriteLine($"{fruitFullPrice:f2}");
                        break;
                    case "Saturday":
                    case "Sunday":
                        fruitPrice = 4.20;
                        fruitFullPrice = fruitPrice * quantity;
                        Console.WriteLine($"{fruitFullPrice:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
