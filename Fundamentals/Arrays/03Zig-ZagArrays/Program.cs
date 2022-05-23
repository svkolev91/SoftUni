using System;
using System.Linq;

namespace _03Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];
            int arrayCounter = 0;

            for (int i = 1; i <= n; i++)
            {
                int[] currentNumbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                
                if (i % 2 != 0)
                {
                    firstArr[arrayCounter] = currentNumbers[0];
                    secondArr[arrayCounter] = currentNumbers[1];
                }
                else
                {
                    firstArr[arrayCounter] = currentNumbers[1];
                    secondArr[arrayCounter] = currentNumbers[0];
                }
                arrayCounter++;
            }

            Console.WriteLine(string.Join(' ',firstArr));
            Console.WriteLine(string.Join(' ',secondArr));
        }
    }
}
