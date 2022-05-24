using System;
using System.Collections.Generic;
using System.Text;

namespace _06ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            
            List<char> result = new List<char>();
            int counter = 0;

            result.Add(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (result[counter] != input[i])
                {
                    result.Add(input[i]);
                    counter++;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
