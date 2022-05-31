﻿using System;
using System.Collections.Generic;
using System.Linq;

class SetsOfElements
{

    //   Create a program that prints a set of elements.
    //   On the first line, you will receive two numbers - n and m, which represent the lengths of two separate sets.
    //   On the next n + m lines, you will receive n numbers, which are the numbers in the first set, and m numbers,
    //   which are in the second set.Find all the unique elements that appear in both of them and print them in the order
    //   in which they appear in the first set - n.
    //  For example:
    //      Set with length n = 4: { 1, 3, 5, 7}
    //      Set with length m = 3: {3, 4, 5}
    //      Set that contains all the elements that repeat in both sets -> {3, 5}


    static void Main()
    {
        int[] numberOfElements = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        
        int n = numberOfElements[0];
        int m = numberOfElements[1];

        HashSet<int> firstSet = new HashSet<int>();
        HashSet<int> secondSet = new HashSet<int>();

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            firstSet.Add(input);
        }

        for (int i = 0; i < m; i++)
        {
            int input = int.Parse(Console.ReadLine());
            secondSet.Add(input);
        }

        firstSet.IntersectWith(secondSet);

        Console.WriteLine(string.Join(" ", firstSet));
    }
}

