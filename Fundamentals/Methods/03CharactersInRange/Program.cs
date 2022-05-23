using System;
using System.Text;

namespace _03CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string result = GetCharactersString(firstChar, secondChar);
            Console.WriteLine(result);

        }

        static string GetCharactersString(char firstChar, char secondChar)
        {
            string result = string.Empty;

            if ((int)firstChar > (int)secondChar)
            {
                for (int i = secondChar + 1; i < firstChar; i++)
                {
                    result+=(char)i + " ";
                }
            }
            else
            {
                for (int i = firstChar + 1; i < secondChar; i++)
                {
                    result += (char)i + " ";
                }
            }

            return result;
        }
    }
}
