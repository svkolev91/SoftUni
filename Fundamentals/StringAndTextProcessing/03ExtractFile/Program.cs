using System;

namespace _03ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int numberOfIndexForExtension = input.LastIndexOf('.');
            string extension = input.Substring(numberOfIndexForExtension + 1);

            int numberOfIndexForName = input.LastIndexOf('\\');
            string fileName = input.Substring(numberOfIndexForName + 1, numberOfIndexForExtension - numberOfIndexForName - 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
