using System;
using System.Collections.Generic;
using System.Linq;

class TriFunction
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

        Console.WriteLine(names.First(name => name.Select(symbol => (int)symbol).Sum() >= n));
    }
}
