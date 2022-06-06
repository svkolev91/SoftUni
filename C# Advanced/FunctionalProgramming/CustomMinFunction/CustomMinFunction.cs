using System;
using System.Collections.Generic;
using System.Linq;

class CustomMinFunction
{

    //Create a simple program that reads from the console a set of integers and prints
    //back on the console the smallest number from the collection.

    static void Main()
    {
        List<int> input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        Func<List<int>, int> getMin = list => list.Min();

        Console.WriteLine(getMin(input));
    }
}
