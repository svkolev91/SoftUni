using System;
using System.Linq;

namespace _08MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int sumToCheck = int.Parse(Console.ReadLine());

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                int currentNum = arr[i];
                int secondNum = 0;

                for (int j = i + 1; j <= arr.Length - 1; j++)
                {
                    secondNum = arr[j];
                    if (secondNum + currentNum == sumToCheck)
                    {
                        Console.WriteLine($"{currentNum} {secondNum}");
                    }
                }
            }

        }
    }
}
