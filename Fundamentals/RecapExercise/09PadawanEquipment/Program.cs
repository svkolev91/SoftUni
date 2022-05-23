using System;

namespace _09PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startingMoney = double.Parse(Console.ReadLine());
            var countOfStudents = int.Parse(Console.ReadLine());
            var lightsaberPrice = double.Parse(Console.ReadLine());
            var robesPrice = double.Parse(Console.ReadLine());
            var beltPrice = double.Parse(Console.ReadLine());
            var totalSumNeeded = 0.0;
            double saberCountOfStudents = Math.Ceiling(countOfStudents + (countOfStudents * 0.1));

            totalSumNeeded = (lightsaberPrice * saberCountOfStudents) + (robesPrice * countOfStudents) + (beltPrice * countOfStudents);

            for (int i = 1; i <= countOfStudents; i++)
            {
                if (i % 6 == 0)
                {
                    totalSumNeeded -= beltPrice;
                }
            }

            if (startingMoney >= totalSumNeeded)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSumNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalSumNeeded - startingMoney):f2}lv more.");
            }

        }
    }
}
