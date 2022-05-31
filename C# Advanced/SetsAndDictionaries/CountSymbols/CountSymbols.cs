using System;
using System.Collections.Generic;
using System.Linq;

class CountSymbols
{
    //  Create a program that reads some text from the console and counts the occurrences of each character in it.
    //  Print the results in alphabetical(lexicographical) order.

    static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<char, int> chars = new Dictionary<char, int>();

        foreach (char symbol in input)
        {
            if (!chars.ContainsKey(symbol))
            {
                chars.Add(symbol, 0);
            }

            chars[symbol]++;
        }

        foreach (var pair in chars.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
        }
    }
}
