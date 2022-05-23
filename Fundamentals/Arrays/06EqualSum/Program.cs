using System;
using System.Linq;

namespace _06EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool isEqual = false;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                int leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }

                int rightSum = 0;
                for (int k = arr.Length - 1; k > i; k--)
                {
                    rightSum += arr[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                }
            }

            if (!isEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}

