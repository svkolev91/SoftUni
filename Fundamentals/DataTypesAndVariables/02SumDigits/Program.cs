using System;

namespace _02SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i <= num.Length - 1; i++)
            {
                int currentNum = num[i] - 48;
                sum += currentNum;
            }
            Console.WriteLine(sum);
        }
    }
}
