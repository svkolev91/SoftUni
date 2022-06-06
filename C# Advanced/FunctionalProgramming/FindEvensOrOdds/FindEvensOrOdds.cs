using System;
using System.Linq;

class FindEvensOrOdds
{

    //You are given a lower and an upper bound for a range of integer numbers.
    //Then a command specifies if you need to list all even or odd numbers in the given range.

    static void Main()
    {
        Predicate<int> isEven = x => x % 2 == 0;

        int[] range = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        string type = Console.ReadLine();

        for (int i = range[0]; i <= range[1]; i++)
        {
            if (type == "even" && isEven(i))
            {
                Console.Write(i + " ");
            }
            
            if (type == "odd" && !isEven(i))
            {
                Console.Write(i + " ");
            }
        }
    }
}
