using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine()
                .ToCharArray();
  
            Dictionary<char, int> occurrences = new Dictionary<char, int>();

            foreach (char letter in chars)
            {
                if (letter == ' ')
                {
                    continue;
                }

                if (occurrences.ContainsKey(letter))
                {
                    occurrences[letter]++;
                }
                else
                {
                    occurrences.Add(letter, 1);
                }
            }

            foreach (var item in occurrences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
