using System;
using System.Collections.Generic;
using System.Linq;

class PredicateForNames
{

    //Write a program that filters a list of names according to their length.
    //On the first line, you will be given an integer n, representing a name's length.
    //On the second line, you will be given some names as strings separated by space.
    //Write a function that prints only the names whose length is less than or equal to n.

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

        Predicate<string> isNameValid = name => name.Length <= n;
        Action<List<string>> filteredNames = list => Console.WriteLine(string.Join("\r\n", list.FindAll(isNameValid)));

        filteredNames(names);
    }

}
