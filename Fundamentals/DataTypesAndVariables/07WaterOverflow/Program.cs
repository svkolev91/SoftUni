using System;

namespace _07WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int waterTankCapacity = 255;

            int numbeOfInputs = int.Parse(Console.ReadLine());
            int totalLiters = 0;

            for (int i = 0; i < numbeOfInputs; i++)
            {
                int currentLiters = int.Parse(Console.ReadLine());

                if (currentLiters <= waterTankCapacity && totalLiters <= 255)
                {
                    totalLiters += currentLiters;
                    if (totalLiters > 255)
                    {
                        Console.WriteLine("Insufficient capacity!");
                        totalLiters -= currentLiters;
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(totalLiters);
        }
    }
}
