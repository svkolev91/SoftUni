using System;

namespace _05AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = SumOfFirstTwoNums(firstNum, secondNum);
            int result = SubtractThirdNumFromSumOfFirstTwoNums(sum, thirdNum);
            Console.WriteLine(result);
        }

        static int SumOfFirstTwoNums(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            return sum;
        }

        static int SubtractThirdNumFromSumOfFirstTwoNums(int sum, int thirdNum)
        {
            int result = sum - thirdNum;

            return result;
        }
    }
}
