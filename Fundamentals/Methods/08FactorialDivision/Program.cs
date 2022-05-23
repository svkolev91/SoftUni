using System;

namespace _08FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secondNum = long.Parse(Console.ReadLine());

            double firstFactorial = CalculateFactorial(firstNum);
            double secondFactorial = CalculateFactorial(secondNum);

            Console.WriteLine($"{firstFactorial/secondFactorial:f2}");
        }


        static double CalculateFactorial(long firstNum)
        {
            for (long i = firstNum -1; i >= 1; i--)
            {
                firstNum *= i;
            }

            return firstNum;
        }
    }
}
