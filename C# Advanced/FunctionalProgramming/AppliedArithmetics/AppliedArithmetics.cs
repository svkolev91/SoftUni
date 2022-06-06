using System;
using System.Collections.Generic;
using System.Linq;

class AppliedArithmetics
{

    //    Create a program that executes some mathematical operations on a given collection.
    //    On the first line, you are given a list of numbers.On the next lines, you are passed different commands
    //    that you need to apply to all the numbers in the list:
    //      •	"add" -> add 1 to each number
    //      •	"multiply" -> multiply each number by 2
    //      •	"subtract" -> subtract 1 from each number
    //      •	"print" -> print the collection
    //      •	"end" -> ends the input


    static void Main()
    {
        List<int> input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        List<int> results = new List<int>();

        Func<List<int>, List<int>> add = list => list.Select(num => num += 1).ToList();
        Func<List<int>, List<int>> multiply = list => list.Select(num => num *= 2).ToList();
        Func<List<int>, List<int>> subtract = list => list.Select(num => num -= 1).ToList();
        Action<List<int>> print = list => Console.WriteLine(string.Join(" ", list));

        string command = Console.ReadLine();

        while (command != "end")
        {
            if (command == "add")
            {
                input = add(input);
            }
            else if (command == "multiply")
            {
                input = multiply(input);
            }
            else if (command == "subtract")
            {
                input = subtract(input);
            }
            else if (command == "print")
            {
                print(input);
            }
            command = Console.ReadLine();
        }
    }
}
