using System;
using System.Linq;

class Largest3Numbers
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int[] sortedNums = numbers.OrderByDescending(x => x)
            .Take(3)
            .ToArray();

        foreach (var num in sortedNums)
        {
            Console.Write(num + " ");
        }


    }
}

