using System;
using System.Linq;

namespace SquaresInMatrix
{
    class SquaresInMatrix
    {

        //Find the count of 2 x 2 squares of equal chars in a matrix.

        //      Input
        //          •	On the first line, you are given the integers rows and cols – the matrix's dimensions.
        //          •	Matrix characters come at the next rows lines (space separated).

        //      Output
        //          •	Print the number of all the squares matrixes you have found.




        static void Main()
        {
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int count = 0;

            char[,] matrix = new char[size[0], size[1]];

            for (int row = 0; row < size[0]; row++)
            {
                char[] line = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(char.Parse)
                        .ToArray();
                for (int col = 0; col < size[1]; col++)
                {
                    matrix[row, col] = line[col];
                }
            }


            for (int row = 0; row < size[0] - 1; row++)
            {
                for (int col = 0; col < size[1] - 1; col++)
                {
                    if (matrix[row,col] == matrix[row, col+1] 
                        && matrix[row,col] == matrix[row +1, col]
                        && matrix[row,col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);

        }
    }
}
