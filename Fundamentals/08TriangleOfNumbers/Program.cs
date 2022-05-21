using System;

namespace _08TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                     Console.Write($"{row} ");
                }

                Console.WriteLine();
            }
        }
    }
}
