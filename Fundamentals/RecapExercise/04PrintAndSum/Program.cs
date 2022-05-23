using System;

namespace _04PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = num1; i <= num2; i++)
            {
                var currentNum = i;
                if (currentNum == num2)
                {
                    Console.WriteLine(currentNum);
                    sum += i;
                    break;
                }
                else
                {
                    Console.Write($"{i} ");
                }
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
