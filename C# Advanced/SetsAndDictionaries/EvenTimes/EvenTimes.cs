using System;
using System.Collections.Generic;

class EvenTimes
{

    //  Create a program that prints a number from a collection, which appears an even number of times in it.
    //  On the first line, you will be given n – the count of integers you will receive.
    //  On the next n lines, you will be receiving the numbers.
    //  It is guaranteed that only one of them appears an even number of times.
    //  Your task is to find that number and print it in the end. 

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<int, int> numbers = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());

            if (!numbers.ContainsKey(input))
            {
                numbers.Add(input, 0);
            }

            numbers[input]++;
        }

        foreach (var pair in numbers)
        {
            if(pair.Value % 2 == 0)
            {
                Console.WriteLine(pair.Key);
                break;
            }
        }
    }
}
