using System;
using System.Collections.Generic;
using System.Linq;

namespace _01ExerciseTrain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfWagons = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            int maxWagonCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmdnArgs = input.Split(" ")
                    .ToArray();
                
                if (cmdnArgs[0] == "Add")
                {
                    listOfWagons.Add(int.Parse(cmdnArgs[1]));
                }
                else
                {
                    int passangers = int.Parse(cmdnArgs[0]);

                    for (int i = 0; i < listOfWagons.Count; i++)
                    {
                        if (listOfWagons[i] + passangers <= maxWagonCapacity)
                        {
                            listOfWagons[i] += passangers;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", listOfWagons));
        }
    }
}
