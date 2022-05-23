using System;

namespace _06StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            var factorielSum = 1;
            var sum = 0;
            var check = int.Parse(num);
            

            for (int i = 0; i <= num.Length - 1; i++)
            {
                int currentNum = num[i] - 48;

                for (int j = 1; j <= currentNum; j++)
                {
                    factorielSum *= j;
                }

                sum += factorielSum;
                factorielSum = 1;
            }

            if (check == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
