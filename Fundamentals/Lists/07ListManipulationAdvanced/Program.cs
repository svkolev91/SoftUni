using System;
using System.Collections.Generic;
using System.Linq;

namespace _07ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            bool hasChanged = false;

            while (true)
            {

                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        list.Add(numberToAdd);
                        hasChanged = true;
                        break;

                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        list.Remove(numberToRemove);
                        hasChanged = true;
                        break;

                    case "RemoveAt":
                        int indexToRemoveAt = int.Parse(tokens[1]);
                        list.RemoveAt(indexToRemoveAt);
                        hasChanged = true;
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsertAt = int.Parse(tokens[2]);
                        list.Insert(indexToInsertAt, numberToInsert);
                        hasChanged = true;
                        break;

                    case "Contains":
                        int numberToCheck = int.Parse(tokens[1]);
                        if (list.Contains(numberToCheck))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }

                        break;

                    case "PrintEven":
                        List<int> evenNumbersList = list.FindAll(x => x % 2 == 0);
                        Console.WriteLine(string.Join(" ", evenNumbersList));
                        break;

                    case "PrintOdd":
                        List<int> oddNumbersList = list.FindAll(x => x % 2 != 0);
                        Console.WriteLine(string.Join(" ", oddNumbersList));
                        break;

                    case "GetSum":
                        int sum = list.Sum();
                        Console.WriteLine(sum);
                        break;

                    case "Filter":
                        List<int> elementsThatMeetTheRequirement = new List<int>();

                        if (tokens[1] == "<")
                        {
                            int filterNum = int.Parse(tokens[2]);
                            elementsThatMeetTheRequirement = list.FindAll(x => x < filterNum);
                        }
                        else if (tokens[1] == ">")
                        {
                            int filterNum = int.Parse(tokens[2]);
                            elementsThatMeetTheRequirement = list.FindAll(x => x > filterNum);
                        }
                        else if (tokens[1] == "<=")
                        {
                            int filterNum = int.Parse(tokens[2]);
                            elementsThatMeetTheRequirement = list.FindAll(x => x <= filterNum);
                        }
                        else if (tokens[1] == ">=")
                        {
                            int filterNum = int.Parse(tokens[2]);
                            elementsThatMeetTheRequirement = list.FindAll(x => x >= filterNum);
                        }


                        Console.WriteLine(string.Join(" ", elementsThatMeetTheRequirement));
                        break;
                }
            }

            if (hasChanged)
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}
