using System;
using System.Text;

namespace _05MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder endResult = new StringBuilder();

            char[] numbers = firstNum.ToCharArray();
            int ostatuk = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int num = int.Parse(numbers[i].ToString());
                int currentNum = multiplier * num + ostatuk;
                ostatuk = 0;
                char[] newNum = currentNum.ToString().ToCharArray();

                if (newNum.Length == 2)
                {
                    endResult.Insert(0 , newNum[1].ToString());
                    ostatuk = int.Parse(newNum[0].ToString());
                }
                else
                {
                    endResult.Insert(0, newNum[0].ToString());
                }

                if (i == 0 && ostatuk != 0)
                {
                    endResult.Insert(0, ostatuk);
                }
            }

            Console.WriteLine(endResult);
        }
    }
}
