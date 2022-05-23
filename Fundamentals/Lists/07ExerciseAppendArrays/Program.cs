using System;
using System.Collections.Generic;
using System.Linq;

namespace _07ExerciseAppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
             .Split('|', StringSplitOptions.RemoveEmptyEntries)
             .ToList();

            
            List<int> output = new List<int>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                int[] arrToAppend = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j <= arrToAppend.Length - 1; j++)
                {
                    output.Add(arrToAppend[j]);
                }
            }


            Console.WriteLine(string.Join(" ", output));
        }
    }
}
