using System;
using System.Linq;

namespace _02VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int vowels = CountVowels(word);
            Console.WriteLine(vowels);
        }

        static int CountVowels(string word)
        {
            int volewsCount = 0;
            char[] vowels = new char[]  { 'a','i','e','o','u' };

            foreach (char ch in word.ToLower())
            {
                if (vowels.Contains(ch))
                {
                    volewsCount++;
                }
            }
            
            return volewsCount;
        }
    }
}
