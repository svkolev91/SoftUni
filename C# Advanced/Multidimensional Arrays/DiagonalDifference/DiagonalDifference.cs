using System;
using System.Linq;

namespace DiagonalDifference
{
    class DiagonalDifference
    {

        //Create a program that finds the difference between the sums of the square matrix diagonals(absolute value).

        //       Input
        //          •	On the first line, you are given the integer N – the size of the square matrix.
        //          •	The next N lines, hold the values for every row – N numbers separated by a space.

        //       Output
        //          •	Print the absolute difference between the sums of the primary and the secondary diagonal.


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
                    matrix[row, col] = line[col];
                }
            }

            int primarySum = 0;
            int secondarySum = 0;

            for (int i = 0; i < size; i++)
            {
                primarySum += matrix[i, i];
                secondarySum += matrix[i, size - 1 - i];
            }

            int results = Math.Abs(primarySum - secondarySum);
            Console.WriteLine(results);
        }
    }
}
