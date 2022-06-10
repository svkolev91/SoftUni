using System;
using System.Collections.Generic;
using System.Linq;

class ListOfPredicates
{

    //Find all numbers in the range 1…N that are divisible by the numbers of a given sequence.
    //On the first line, you will be given an integer N – which is the end of the range.
    //On the second line, you will be given a sequence of integers which are the dividers.Use predicates/functions.

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> dividers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();


        List<int> results = new List<int>();


        for (int i = 1; i <= n; i++)
        {
            if (CheckDivisible(dividers, i))
            {
                results.Add(i);
            }
        }

        Console.WriteLine(string.Join(" ", results));
    }

    static bool CheckDivisible(List<int> dividers, int i)
    {
        Predicate<int> isDivisible = num => i % num == 0;
        foreach (var divider in dividers)
        {
            if (!isDivisible(divider))
            {
                return false;
            }
        }
        return true;
    }
}
