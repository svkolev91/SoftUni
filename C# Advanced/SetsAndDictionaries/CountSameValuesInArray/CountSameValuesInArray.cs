using System;
using System.Collections.Generic;
using System.Linq;

class CountSameValuesInArray
{

    //Create a program that counts in a given array of double values the number of occurrences of each value.

    static void Main()
    {
        string[] input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> numbersAndTheirCount = new Dictionary<string, int>();

        foreach (var num in input)
        {
            if (!numbersAndTheirCount.ContainsKey(num))
            {
                numbersAndTheirCount[num] = 1;
            }
            else
            {
                numbersAndTheirCount[num]++;
            }
        }

        foreach (var pair in numbersAndTheirCount)
        {
            string num = pair.Key;
            int count = pair.Value;
            Console.WriteLine($"{num} - {count} times");
        }
    }
}

