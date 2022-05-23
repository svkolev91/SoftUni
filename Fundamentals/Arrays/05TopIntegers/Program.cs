using System;
using System.Linq;

namespace _05TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] finalArray= new int[initialArray.Length];
            int finalArrayCounter = 0;


            for (int i = 0; i <= initialArray.Length - 1; i++)
            {
                int currentNum = initialArray[i];
                bool isTopInteger = true;

                for (int j = i + 1; j <= initialArray.Length - 1; j++)
                {
                    int nextNum = initialArray[j];

                    if (currentNum <= nextNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    finalArray[finalArrayCounter] = currentNum;
                    finalArrayCounter++;
                }
            }

            for (int i = 0; i < finalArrayCounter; i++)
            {
                Console.Write($"{finalArray[i]} ");
            }
        }
    }
}
