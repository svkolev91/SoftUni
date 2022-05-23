using System;

namespace _07NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();    
            PrintMatrix(num);

        }


        static void PrintMatrix(string num)
        {
            int number = int.Parse(num);

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
