﻿using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 1;
            int currNum = 1;
            bool isEqual = false;
            while (isEqual == false)
            {
                for (int i = 1; i <= row; i++)
                {
                    Console.Write(currNum + " ");
                    currNum++;
                    if (currNum > n)
                    {
                        isEqual = true;
                        break;
                    }
                }
                Console.WriteLine();
                row++;
            }
        }
    }
}
