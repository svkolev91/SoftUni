using System;

namespace _04SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int sumOfChars = 0;

            for (int i = 0; i < numberOfInputs; i++)
            {
                char input = char.Parse(Console.ReadLine());
                sumOfChars += (int)input;

            }
            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}
