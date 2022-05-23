using System;
using System.Collections.Generic;
using System.Linq;

namespace _06MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(GetMiddleLetter(input));
        }


        static string GetMiddleLetter(string input)
        {
            int length = input.Length;
            string result = string.Empty;

            if (length % 2 == 1)
            {
                result = input[length / 2].ToString();
            }
            else
            {
                result = input[length / 2 - 1].ToString() + input[length / 2].ToString();
            }

            return result;
        }
    }
}
