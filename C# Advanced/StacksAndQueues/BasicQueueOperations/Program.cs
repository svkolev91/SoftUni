using System;
using System.Collections.Generic;
using System.Linq;


namespace BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] details = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = details[0];
            int s = details[1];
            int x = details[2];

            List<int> queueNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(queueNumbers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                int smallestNumber = queue.Min();
                Console.WriteLine(smallestNumber);
            }
        }
    }
}
