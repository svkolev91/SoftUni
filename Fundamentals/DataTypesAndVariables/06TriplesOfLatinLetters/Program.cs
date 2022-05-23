using System;

namespace _06TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char a = 'a'; a < 'a' + n; a++)
            {
                for (char i = 'a' ; i < 'a' + n; i++)
                {
                    for (char j = 'a'; j < 'a' + n; j++)
                    {
                        Console.WriteLine($"{a}{i}{j}");
                    }
                }
            }
        }
    }
}
