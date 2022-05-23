using System;

namespace _09SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int spiceHarvested = 0;
            int daysCount = 0;

            while (startingYield >= 100)
            {
                daysCount++;
                spiceHarvested += startingYield;
                startingYield -= 10;

                if (spiceHarvested >= 26)
                {
                    spiceHarvested -= 26;

                }
            }

            if (spiceHarvested >= 26)
            {
                spiceHarvested -= 26;

            }

            Console.WriteLine(daysCount);
            Console.WriteLine(spiceHarvested);
        }
    }
}
