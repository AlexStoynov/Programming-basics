using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pricePerGPU = int.Parse(Console.ReadLine());
            int pricePerAdapter = int.Parse(Console.ReadLine());
            double priceForElectricityFor1DayPerGPU = double.Parse(Console.ReadLine());
            double moneyForOneDayPerGPU = double.Parse(Console.ReadLine());
            double GPUFullPrice = pricePerGPU * 13;
            double AdapterFullPrice = pricePerAdapter * 13;
            double moneySpent = GPUFullPrice + AdapterFullPrice + 1000;
            double winningFromGPUPerDay = moneyForOneDayPerGPU - priceForElectricityFor1DayPerGPU;
            double fullWinningPerDay = 13 * winningFromGPUPerDay;
            double daysForWinning = Math.Ceiling(moneySpent / fullWinningPerDay);
            Console.WriteLine(moneySpent);
            Console.WriteLine(daysForWinning);
        }
    }
}
