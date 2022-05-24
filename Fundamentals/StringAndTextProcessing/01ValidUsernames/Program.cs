using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] userNames = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> validUsernames = new List<string>();

            foreach (string user in userNames)
            {
                char[] chars = user.ToCharArray();
                string currntWord = user;
                if (user.Length < 3 || user.Length > 16)
                {
                    continue;
                }

                bool isValid = true;
                foreach (char letter in chars)
                {
                    if (!char.IsLetterOrDigit(letter) && letter != '-' && letter != '_')
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    validUsernames.Add(user);
                }
            }
            foreach (var item in validUsernames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
