using System;
using System.Collections.Generic;
using System.Linq;

class KnightsOfHonor
{

    //Create a program that reads a collection of names as strings from the console,
    //appends "Sir" in front of every name and prints it back in the console.Use Action<T>.

    static void Main()
    {
        Action<string> printSir = name => Console.WriteLine("Sir " + name);
        List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

        input.ForEach(printSir);

    }
}
