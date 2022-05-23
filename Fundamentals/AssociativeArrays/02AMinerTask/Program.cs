using System;
using System.Collections.Generic;

namespace _02AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            You will be given a sequence of strings, each on a new line.
            //            Every odd line on the console is representing a resource(e.g.Gold, Silver, Copper, and so on) and every even - quantity.Your task is to collect the resources and print them each on a new line.
            //Print the resources and their quantities in the following format:
            //            "{resource} –> {quantity}"
            //The quantities will be in the range[1 … 2 000 000 000]

            Dictionary<string, long> resourcesList = new Dictionary<string, long>();

            string resourceType = Console.ReadLine();
            long resourceQuantity = long.Parse(Console.ReadLine());

            while (resourceType != "stop")
            {
                if (resourcesList.ContainsKey(resourceType))
                {
                    resourcesList[resourceType] += resourceQuantity;
                }
                else
                {
                    resourcesList.Add(resourceType, resourceQuantity);
                }

                resourceType = Console.ReadLine();
                if (resourceType == "stop")
                {
                    break;
                }
                resourceQuantity = long.Parse(Console.ReadLine());
            }

            foreach (var item in resourcesList)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
