using System;
using System.Linq;

namespace MaximalSum
{
    class MaximalSum
    {

        //Create a program that reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 that has a maximal sum of its elements.

        //      Input
        //          •	On the first line, you will receive the rows N and columns M.On the next N lines, you will receive each row with its columns.

        //      Output
        //          •	Print the elements of the 3 x 3 square as a matrix, along with their sum.


        static void Main()
        {
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int cols = size[1];

            int sum = 0;

            int[,] matrix = new int[rows, cols];
            int[,] maximalMatrix = new int[3,3];

            FillMatrix(matrix);

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currSum > sum)
                    {
                        sum = currSum;

                        maximalMatrix = new int[3, 3]
                        {
                            { matrix[row, col] , matrix[row, col + 1] , matrix[row, col + 2] },
                            { matrix[row + 1, col] , matrix[row + 1, col + 1] , matrix[row + 1, col + 2] },
                            { matrix[row + 2, col], matrix[row + 2, col + 1], matrix[row + 2, col + 2]}
                        };

                    }
                }
            }

            Console.WriteLine($"Sum = {sum}");

            for (int row = 0; row < maximalMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < maximalMatrix.GetLength(1); col++)
                {
                    Console.Write($"{maximalMatrix[row,col]} ");
                }
                Console.WriteLine();
            }



        }

        static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
