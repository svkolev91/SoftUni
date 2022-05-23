using System;

namespace _02CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] secondArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string output = string.Empty;

            for(int i = 0; i < secondArray.Length; i++)
            {
                foreach (var item in firstArray)
                {
                    if (item == secondArray[i])
                    {
                        output += (item + " ");
                    }
                }
            }
            Console.WriteLine(output);
        }
    }
}
