using System;
using System.Linq;

namespace _01Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] passangers = new int[n];
            int sum = 0;

            for (int i = 0; i < passangers.Length; i++)
            {
                passangers[i] = int.Parse(Console.ReadLine());
                sum += passangers[i];
            }
            //int[] passangers = Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();


            //foreach (var item in passangers)
            //{
            //    sum += item;
            //}
            Console.WriteLine(string.Join(" ", passangers));
            Console.WriteLine(sum);
        }
    }
}
