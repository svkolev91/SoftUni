using System;
using System.Collections.Generic;
using System.Linq;

namespace _03ExerciseHouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> endList = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (input.Contains("not"))
                {
                    if (endList.Contains(input[0]))
                    {
                        endList.Remove(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                }
                else
                {
                    if (endList.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                    else
                    {
                        endList.Add(input[0]);
                    }

                }
            }

            for (int i = 0; i < endList.Count; i++)
            {
                Console.WriteLine(endList[i]);
            }


        }
    }
}
