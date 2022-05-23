using System;
using System.Collections.Generic;
using System.Linq;

namespace _02ExerciseChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNums = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Delete")
                {
                    int toBeDeleted = int.Parse(tokens[1]);
                    listOfNums.RemoveAll(x => x == toBeDeleted);
                }
                else if (tokens[0] == "Insert")
                {
                    int element = int.Parse(tokens[1]);
                    int indexOfElement = int.Parse(tokens[2]);

                    listOfNums.Insert(indexOfElement, element);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(string.Join(" ", listOfNums));
        }
    }
}
