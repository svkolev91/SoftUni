using System;
using System.Collections.Generic;
using System.Linq;

class ReverseAndExclude
{

    //Create a program that reverses a collection and removes elements that are divisible by a given integer n.

    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Reverse()
            .ToList();

        int n = int.Parse(Console.ReadLine());

        Predicate<int> isDivisibleByN = num => num % n != 0;

        numbers = numbers.FindAll(isDivisibleByN);
        Console.WriteLine(string.Join(" ", numbers));
    }
}
