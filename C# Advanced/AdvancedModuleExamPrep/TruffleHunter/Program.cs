using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] forest = new char[n, n];

        FillMatrix(forest);
        Dictionary<char, int> trufflesCollected = new Dictionary<char, int>();
        int eatenByBoar = 0;

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "Stop the hunt")
            {
                break;
            }

            string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int currRow = int.Parse(cmdArgs[1]);
            int currCol = int.Parse(cmdArgs[2]);

            if (cmdArgs[0] == "Collect")
            {
                if (!CheckIfValid(forest, currRow, currCol))
                {
                    continue;
                }

                if (forest[currRow,currCol] != '-') 
                {
                    char trufle = forest[currRow, currCol];
                    if (!trufflesCollected.ContainsKey(trufle))
                    {
                        trufflesCollected.Add(trufle, 0);
                    }
                    trufflesCollected[trufle]++;
                    forest[currRow, currCol] = '-';
                }
                else
                {
                    continue;
                }
            }
            else if (cmdArgs[0] == "Wild_Boar")
            {
                string direction = cmdArgs[3];

                if (forest[currRow, currCol] != '-')
                {
                    eatenByBoar++;
                    forest[currRow, currCol] = '-';
                }

                eatenByBoar = MoveBoar(forest,currRow,currCol,eatenByBoar,direction);
            }

        }

        PrintResults(trufflesCollected, eatenByBoar,forest);
    }

    private static void PrintResults(Dictionary<char, int> trufflesCollected, int eatenByBoar, char[,] forest)
    {
        Console.WriteLine($"Peter manages to harvest {trufflesCollected['B']} black, {trufflesCollected['S']} summer, and {trufflesCollected['W']} white truffles.");
        Console.WriteLine($"The wild boar has eaten {eatenByBoar} truffles.");

        for (int row = 0; row < forest.GetLength(0); row++)
        {
            for (int col = 0; col < forest.GetLength(1); col++)
            {
                Console.Write($"{forest[row, col]} ");
            }
            Console.WriteLine();
        }
    }

    private static int MoveBoar(char[,] forest, int currRow, int currCol, int eatenByBoar, string direction)
    {
        if (direction == "up")
        {
            for (int row = currRow - 2; row >= 0; row-=2)
            {
                if (forest[row, currCol] != '-')
                {
                    eatenByBoar++;
                    forest[row, currCol] = '-';
                }
            }
        }
        else if (direction == "down")
        {
            for (int row = currRow + 2; row < forest.GetLength(0); row+=2)
            {
                if (forest[row, currCol] != '-')
                {
                    eatenByBoar++;
                    forest[row, currCol] = '-';
                }
            }
        }
        else if (direction == "left")
        {
            for (int col = currCol - 2; col >= 0; col-= 2)
            {
                if (forest[currRow, col] != '-')
                {
                    eatenByBoar++;
                    forest[currRow, col] = '-';
                }
            }
        }
        else if (direction == "right")
        {
            for (int col = currCol + 2; col < forest.GetLength(1); col += 2)
            {
                if (forest[currRow, col] != '-')
                {
                    eatenByBoar++;
                    forest[currRow, col] = '-';
                }
            }
        }

        return eatenByBoar;
    }

    private static bool CheckIfValid(char[,] forest, int currRow, int currCol)
    {
        if (currRow > forest.GetLength(0) || currRow < 0 ||
            currCol > forest.GetLength(1) || currCol < 0)
        {
            return false;
        }

        return true;
    }

    private static void FillMatrix(char[,] forest)
    {
        for (int row = 0; row < forest.GetLength(0); row++)
        {
            char[] rowData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            for (int col = 0; col < forest.GetLength(1); col++)
            {
                forest[row, col] = rowData[col];
            }
        }
    }
}
