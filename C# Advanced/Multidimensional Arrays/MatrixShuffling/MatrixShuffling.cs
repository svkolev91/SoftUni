using System;
using System.Linq;

namespace MatrixShuffling
{
    internal class MatrixShuffling
    {

        //  Write a program that reads a string matrix from the console and performs certain operations with its elements.
        //  User input is provided in a similar way as in the problems above – first, you read the dimensions and then the data. 

        //  Your program should then receive commands in the format: "swap row1 col1 row2 col2" where row1, col1, row2, col2 are coordinates in the matrix.
        //  For a command to be valid, it should start with the "swap" keyword along with four valid coordinates (no more, no less).
        //  You should swap the values at the given coordinates (cell[row1, col1] with cell [row2, col2]) and print the matrix at each step(thus you'll be able to check if the operation was performed correctly). 
        //  If the command is not valid (doesn't contain the keyword "swap", has fewer or more coordinates entered or the given coordinates do not exist),
        //  print "Invalid input!" and move on to the next command.
        //  Your program should finish when the string "END" is entered.



        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int row = matrixSize[0]; 
            int col = matrixSize[1];

            string[,] matrix = new string[row, col];

            FillMatrix(matrix);

            string cmdArgs = Console.ReadLine();

            while (cmdArgs != "END")
            {
                string[] strings = cmdArgs.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (strings.Length == 0 || !IsCommandValid(strings, row, col))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int firstNumRow = int.Parse(strings[1]);
                    int firstNumCol = int.Parse(strings[2]);
                    int secondNumRow = int.Parse(strings[3]);
                    int secondNumCol = int.Parse(strings[4]);

                    string firstElement = matrix[firstNumRow, firstNumCol];
                    string secondElement = matrix[secondNumRow, secondNumCol];

                    matrix[firstNumRow, firstNumCol] = secondElement;
                    matrix[secondNumRow, secondNumCol] = firstElement;

                    PrintMatrix(matrix);
                }
                cmdArgs = Console.ReadLine();
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        static bool IsCommandValid(string[] strings, int row, int col)
        {
            if (strings[0] != "swap" || strings.Length != 5)
            {
                return false;
            }
            
            int num1 = int.Parse(strings[1]);
            int num2 = int.Parse(strings[2]);
            int num3 = int.Parse(strings[3]);
            int num4 = int.Parse(strings[4]);

            if (num1 >= row || num3 >= row || num2 >= col || num4 >= col)
            {
                return false;
            }

            return true;
        }

        static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }
    }
}
