﻿using System;

namespace _01IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            long result = 0;

            result = num1 + num2;
            result /= num3;
            result *= num4;
            Console.WriteLine(result);
        }
    }
}
