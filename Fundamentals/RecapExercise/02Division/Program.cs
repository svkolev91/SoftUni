using System;

namespace _02Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var divNum = 0;

            if (num % 2 == 0)
            {
                divNum = 2;
            }

            if (num % 3 == 0)
            {
                divNum = 3;
            }

            if (num % 6 == 0)
            {
                divNum = 6;
            }

            if (num % 7 == 0)
            {
                divNum = 7;
            }

            if (num % 10 == 0)
            {
                divNum = 10;
            }

            if (divNum == 10 || divNum == 7 || divNum == 6 || divNum == 3 || divNum == 2)
            {
                Console.WriteLine($"The number is divisible by {divNum}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
