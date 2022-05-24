using System;

namespace _02CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            char[] firstString = input[0].ToCharArray();
            char[] secondString = input[1].ToCharArray();

            if (firstString.Length == secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    sum += firstString[(int)i] * secondString[(int)i];
                }
            }
            else if (firstString.Length < secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    sum += firstString[(int)i] * secondString[(int)i];
                }

                int lengthDifference = secondString.Length - firstString.Length;
                string remainingLetters = input[1].Substring(firstString.Length, lengthDifference);
                char[] remainingCharsArr = remainingLetters.ToCharArray();

                foreach (var letter in remainingCharsArr)
                {
                    int numericValue = (int)letter;
                    sum += numericValue;
                }
            }
            else
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    sum += firstString[(int)i] * secondString[(int)i];
                }

                int lengthDifference = firstString.Length - secondString.Length;
                string remainingLetters = input[0].Substring(secondString.Length, lengthDifference);
                char[] remainingCharsArr = remainingLetters.ToCharArray();

                foreach (var letter in remainingCharsArr)
                {
                    int numericValue = (int)letter;
                    sum += numericValue;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
