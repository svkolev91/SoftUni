using System;
using System.Collections.Generic;

namespace _10TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            for (int i = 17; i <= inputNum; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }

        }

        static bool IsTopNumber(int inputNum)
        {
            string numToCheck = inputNum.ToString();

            if (IsSumOfDigitsDivisible(numToCheck) && HasAtLeastOneOddDigit(numToCheck))
            {
                return true;
            }

            return false;
        }


        static bool IsSumOfDigitsDivisible(string number)
        {
            int sumOfDigits = 0;
            

            for (int i = 0; i < number.Length; i++)
            {
                sumOfDigits += number[i];
            }

            if (sumOfDigits % 8 == 0)
            {
                return true;
            }

            return false;
        }

        static bool HasAtLeastOneOddDigit(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }
    }


}
