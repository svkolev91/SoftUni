using System;
using System.Linq;

namespace _04ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int cycles = int.Parse(Console.ReadLine());

            // Logics


            for (int i = 0; i < cycles; i++)
            {
                int firstIndex = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = firstIndex;
            }
            Console.WriteLine(string.Join(' ',array));
        }
    }
}
