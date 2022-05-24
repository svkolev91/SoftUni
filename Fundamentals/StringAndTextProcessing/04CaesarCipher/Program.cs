using System;
using System.Text;

namespace _04CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder encryptedText = new StringBuilder();

            char[] allChars = input.ToCharArray();

            foreach (var item in allChars)
            {
                int currentChar = (int)item;
                int newCharNum = currentChar + 3;
                char newChar = (char)newCharNum;
                encryptedText.Append(newChar);
            }

            Console.WriteLine(encryptedText);
        }
    }
}
