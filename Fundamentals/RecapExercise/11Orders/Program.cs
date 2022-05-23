using System;

namespace _11Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfOrders = int.Parse(Console.ReadLine());
            double finalSum = 0;

            for (int i = 1; i <= numOfOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                double currentOrderTotal = ((daysInMonth * capsulesCount) * pricePerCapsule);
                finalSum += currentOrderTotal;
                Console.WriteLine($"The price for the coffee is: ${currentOrderTotal:f2}");
            }

            Console.WriteLine($"Total: ${finalSum:f2}");
        }
    }
}
