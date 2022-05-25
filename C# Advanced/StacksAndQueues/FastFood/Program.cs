using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalFood = int.Parse(Console.ReadLine()); 
            Queue<int> orders = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Console.WriteLine(orders.Max());

            while (true)
            {
                if (orders.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                    break;
                }

                if (orders.Peek() <= totalFood)
                {
                    totalFood -= orders.Peek();
                    orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    break;
                }
            }

            
        }
    }
}
