using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] line = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row,col] = line[col];
                }
            }

            int primarySum = 0;
            int secondarySum = 0;

            for (int i = 0;i < size; i++)
            {
                primarySum += matrix[i, i];
                secondarySum += matrix[i,size - 1 - i];
            }

            int results = Math.Abs(primarySum - secondarySum);
            Console.WriteLine(results);
        }
    }
}
