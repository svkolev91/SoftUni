using System;
using System.Collections.Generic;
using System.Linq;

namespace _02GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> numbers2 = new List<int>();


            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int currentNum = numbers[i] + numbers[numbers.Count - 1 - i];
                numbers2.Add(currentNum);
            }

            if (numbers.Count % 2 != 0)
            {
                numbers2.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", numbers2));
        }
    }
}
