using System;
using System.Collections.Generic;
using System.Linq;

namespace _05ExerciseBombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<int> listOfNums = Console.ReadLine()
             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToList();

            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int bomb = arr[0];
            int powerOfBomb = arr[1];

            while (true)
            {
                int indexOfBomb = listOfNums.IndexOf(bomb);
                if (indexOfBomb == -1)
                {
                    break;
                }
                DetonateBomb(listOfNums, indexOfBomb, powerOfBomb);
            }

            Console.WriteLine(listOfNums.Sum());
        }

        static void DetonateBomb(List<int> listOfNums, int indexOfBomb, int powerOfBomb)
        {
            
            int rightCount = indexOfBomb + powerOfBomb;

            for (int i = indexOfBomb; i <= rightCount; i++)
            {
                if (indexOfBomb >= listOfNums.Count)
                {
                    break;
                }

                listOfNums.RemoveAt(indexOfBomb);
            }

            int leftCount = indexOfBomb - powerOfBomb;
            if (leftCount < 0)
            {
                leftCount = 0;
            }

            for (int i = leftCount; i < indexOfBomb; i++)
            {
                listOfNums.RemoveAt(leftCount);
            }
        }
    }
}
