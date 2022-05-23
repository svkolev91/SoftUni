using System;
using System.Collections.Generic;
using System.Linq;

namespace _04ExerciseListOperations
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
                string command = Console.ReadLine();
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command == "End")
                {
                    break;
                }

                if (cmdArgs.Contains("Add"))
                {
                    int numToAdd = int.Parse(cmdArgs[1]);
                    listOfNums.Add(numToAdd);
                }
                else if (cmdArgs.Contains("Insert"))
                {
                    int numToInsert = int.Parse(cmdArgs[1]);
                    int indexToInsert = int.Parse(cmdArgs[2]);

                    if (indexToInsert >= listOfNums.Count || indexToInsert < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    else
                    {
                        listOfNums.Insert(indexToInsert, numToInsert);
                    }
                }
                else if (cmdArgs.Contains("Remove"))
                {
                    int numOfIndexToRemove = int.Parse(cmdArgs[1]);
                    if (numOfIndexToRemove >= listOfNums.Count || numOfIndexToRemove < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    else
                    {
                        listOfNums.RemoveAt(numOfIndexToRemove);
                    }
                }
                else if (cmdArgs.Contains("left"))
                {
                    int numberOfItterations = int.Parse(cmdArgs[2]);
                    listOfNums = ReArrangeListToTheLeft(listOfNums, numberOfItterations);
                }
                else if (cmdArgs.Contains("right"))
                {
                    int numberOfItterations = int.Parse(cmdArgs[2]);
                    listOfNums = ReArrangeListToTheRight(listOfNums, numberOfItterations);
                }
            }

            Console.WriteLine(string.Join(" ", listOfNums));
        }

        static List<int> ReArrangeListToTheLeft(List<int> numbers, int numberOfItterations)
        {

            int realCountOfItterations = numberOfItterations % numbers.Count;
            
            for (int i = 0; i < realCountOfItterations; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }

            return numbers;
        }

        static List<int> ReArrangeListToTheRight(List<int> numbers, int numberOfItterations)
        {
            int realCountOfItterations = numberOfItterations % numbers.Count;

            for (int i = 0; i < realCountOfItterations; i++)
            {
                numbers.Insert(0, numbers[numbers.Count - 1]);
                numbers.RemoveAt(numbers.Count - 1);
            }

            return numbers;
        }
    }
}
