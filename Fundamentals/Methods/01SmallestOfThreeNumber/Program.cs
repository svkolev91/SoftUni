using System;

namespace _01SmallestOfThreeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallestNum = int.MaxValue;

            for (int i = 0; i < 3; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                smallestNum = CompareIntegers(smallestNum, currentNum);
            }
            Console.WriteLine(smallestNum);

            static int CompareIntegers(int num1, int num2)
            {
                if (num1 > num2)
                {
                    return num2;
                }
                return num1;
            }
        }
    }
}
