using System;
using System.Collections.Generic;
using System.Linq;

namespace _09PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                if (IsPalindrome(input))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }


                input = Console.ReadLine();
            }

        }

        static bool IsPalindrome(string input)
        {
            List<char> inputList = input.ToList();

            List<char> reversedInput = new List<char>();

            for (int i = 0; i < inputList.Count; i++)
            {
                reversedInput.Add(inputList[i]);    
            }

            reversedInput.Reverse();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] == reversedInput[i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
