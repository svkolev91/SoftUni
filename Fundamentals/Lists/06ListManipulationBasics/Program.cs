using System;
using System.Collections.Generic;
using System.Linq;

namespace _06ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();



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
                    break;

                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        list.Remove(numberToRemove);
                        break;

                    case "RemoveAt":
                        int indexToRemoveAt = int.Parse(tokens[1]);
                        list.RemoveAt(indexToRemoveAt);
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsertAt = int.Parse( tokens[2]);    
                        list.Insert(indexToInsertAt, numberToInsert);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ",list));

        }
    }
}
