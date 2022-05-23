using System;

namespace _10RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lostGames = int.Parse(Console.ReadLine());
            var headsetPrice = double.Parse(Console.ReadLine());
            var mousePrice = double.Parse(Console.ReadLine());
            var keyboardPrice = double.Parse(Console.ReadLine());
            var displayPrice = double.Parse(Console.ReadLine());

            var counterHeadsets = 0;
            var counterMouse = 0;
            var counterKeyboard = 0;
            var counterDisplay = 0;

            var totalSum = 0.0;
 
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    counterHeadsets++;
                }
                if (i % 3 == 0)
                {
                    counterMouse++;
                }
                if (i % 6 == 0)
                {
                    counterKeyboard++;
                    if (counterKeyboard % 2 == 0)
                    {
                        counterDisplay++;
                    }
                }
                
            }

            totalSum = (counterHeadsets * headsetPrice) + (counterMouse * mousePrice) + (counterKeyboard * keyboardPrice) + (counterDisplay * displayPrice);
            Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");
        }
    }
}
