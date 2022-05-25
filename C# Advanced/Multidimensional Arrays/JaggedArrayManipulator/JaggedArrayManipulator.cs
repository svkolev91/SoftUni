using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    internal class JaggedArrayManipulator
    {
        //Create a program that populates, analyzes and manipulates the elements of a matrix with an unequal length of its rows.
        //First, you will receive an integer N equal to the number of rows in your matrix.
        //On the next N lines, you will receive sequences of integers, separated by a single space.Each sequence is a row in the matrix.
        //After populating the matrix, start analyzing it.If a row and the one below it have equal length, multiply each element in both of them by 2, otherwise - divide by 2.

        //  Then, you will receive commands. There are three possible commands:
        //      •	"Add {row} {column} {value}" - add { value}
        //        to the element at the given indexes, if they are valid.
        //      •	"Subtract {row} {column} {value}" - subtract {value} from the element at the given indexes, if they are valid.
        //      •	"End" - print the final state of the matrix(all elements separated by a single space) and stop the program.

        //  Input
        //      •	On the first line, you will receive the number of rows of the matrix - integer N.
        //      •	On the next N lines, you will receive each row – sequence of integers, separated by a single space
        //      •	{value} will always be an integer number.
        //      •	Then you will be receiving commands until reading "End".

        //  Output
        //      •	The output should be printed on the console and it should consist of N lines.
        //      •	Each line should contain a string representing the respective row of the final matrix, elements separated by a single space.



        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    matrix[row] = matrix[row].Select(el => el * 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(el => el * 2).ToArray();
                }
                else
                {
                    matrix[row] = matrix[row].Select(el => el / 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(el => el / 2).ToArray();
                }
            }



            string command = Console.ReadLine();

            while (command != "End")
            {
                int row = int.Parse(command.Split()[1]);
                int col = int.Parse(command.Split()[2]);
                int value = int.Parse(command.Split()[3]);


                if (command.StartsWith("Add"))
                {
                    if (row >= 0 && row < rows && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] += value;
                    }
                }
                else if (command.StartsWith("Subtract"))
                {
                    if (row >= 0 && row < rows && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] -= value;
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
