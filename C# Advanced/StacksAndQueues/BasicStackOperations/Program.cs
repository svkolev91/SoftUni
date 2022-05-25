using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] details = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = details[0];
            int s = details[1];
            int x = details[2];

            List<int> stackNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(stackNumbers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                int smallestNumber = stack.Min();
                Console.WriteLine(smallestNumber);
            }
        }
    }
}
