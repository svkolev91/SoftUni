using System;
using System.Collections.Generic;
using System.Linq;

namespace _06ExerciseCardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine()
             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToList();


            List<int> secondHand = Console.ReadLine()
             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToList();

            while (true)
            {
                if (firstHand[0] > secondHand[0])
                {
                    firstHand.Add(firstHand[0]);
                    firstHand.Add(secondHand[0]);
                }
                else if (firstHand[0] < secondHand[0])
                {
                    secondHand.Add(secondHand[0]);
                    secondHand.Add(firstHand[0]);
                }

                firstHand.Remove(firstHand[0]);
                secondHand.Remove(secondHand[0]);

                if (firstHand.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
                    break;
                }
                else if (secondHand.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
                    break;
                }
            }

        }
    }
}
