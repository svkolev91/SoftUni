using System;
using System.Text.RegularExpressions;

namespace _02MessageDecrypter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            string pattern = @"^([$%])(?<tag>[A-Z]{1}[a-z]{2,})\1\:\ {1}\[{1}(?<firstNum>[\d]+)\]{1}\|{1}\[{1}(?<secondNum>[\d]+)\]{1}\|{1}\[{1}(?<thirdNum>[\d]+)\]{1}\|{1}$";

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string tag = match.Groups["tag"].Value;
                    int firstNum = int.Parse(match.Groups["firstNum"].Value);
                    int secondNum = int.Parse(match.Groups["secondNum"].Value);
                    int thirdNum = int.Parse(match.Groups["thirdNum"].Value);
                    char letter1 = (char)firstNum;
                    char letter2 = (char)secondNum;
                    char letter3 = (char)thirdNum;

                    Console.WriteLine($"{tag}: {letter1.ToString() + letter2.ToString() + letter3.ToString()}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }


            }
        }
    }
}
