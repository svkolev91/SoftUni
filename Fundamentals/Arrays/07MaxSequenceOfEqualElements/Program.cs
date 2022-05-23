using System;
using System.Linq;

namespace _07MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numToPrint = 0;
            int countOfNum = 0;
            int highestCount = 0;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                int numOfSequence = arr[i];
                int currentNumCount = 0;
                for (int j = i; j <= arr.Length - 1; j++)
                {
                    if (arr[j] == numOfSequence)
                    {
                        currentNumCount++;
                    }
                    else
                    {
                        currentNumCount = 0;
                    }

                    if (currentNumCount > highestCount)
                    {
                        highestCount = currentNumCount;
                        numToPrint = numOfSequence;
                    }

                }
            }

            int[] arrToPrint = new int[highestCount];

            for (int i = 0; i <= arrToPrint.Length - 1; i++)
            {
                arrToPrint[i] = numToPrint;
            }

            Console.WriteLine(string.Join(' ', arrToPrint));
        }
    }
}
