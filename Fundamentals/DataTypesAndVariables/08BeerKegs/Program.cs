using System;

namespace _08BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            var bestKeg = string.Empty;
            var volume = 0.0;

            for (int i = 0; i < numberOfKegs; i++)
            {
                var currentKeg = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());

                var currentVolume = Math.PI * (radius * radius) * height;

                if (currentVolume > volume)
                {
                    bestKeg = currentKeg;
                    volume = currentVolume;
                }
            }

            Console.WriteLine(bestKeg);
        }
    }
}
