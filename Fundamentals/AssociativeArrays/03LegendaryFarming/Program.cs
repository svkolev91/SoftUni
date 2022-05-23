using System;
using System.Collections.Generic;
using System.Linq;

namespace _03LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
                {"shards", 0 },
                {"motes", 0 },
                {"fragments", 0 }
            };

            Dictionary<string, int> junk = new Dictionary<string, int>();

            string itemObtained = string.Empty;

            while (String.IsNullOrEmpty(itemObtained))
            {
                string input = Console.ReadLine().ToLower();
                string[] currentMaterials = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                ProcessMaterials(keyMaterials, junk, currentMaterials, ref itemObtained);
            }

            PrintResults(keyMaterials, junk, itemObtained);
        }

        static void ProcessMaterials(Dictionary<string, int> keyMaterials,
            Dictionary<string, int> junk, string[] currentMaterials,
            ref string itemObtained)
        {
            const int minCraftMaterialQty = 250;

            Dictionary<string, string> craftingTable = new Dictionary<string, string>()
            {
                {"shards", "Shadowmourne" },
                {"fragments", "Valanyr" },
                {"motes", "Dragonwrath" }
            };

            for (int i = 0; i < currentMaterials.Length; i+= 2)
            {
                int currMatQty = int.Parse(currentMaterials[i]);
                string currMaterial = currentMaterials[i+1];

                if (keyMaterials.ContainsKey(currMaterial))
                {
                    keyMaterials[currMaterial] += currMatQty;
                    if (keyMaterials[currMaterial] >= minCraftMaterialQty)
                    {
                        itemObtained = craftingTable[currMaterial];
                        keyMaterials[currMaterial] -= minCraftMaterialQty;
                        break;
                    }
                }
                else
                {
                    if (!junk.ContainsKey(currMaterial))
                    {
                        junk[currMaterial] = 0;
                    }
                    junk[currMaterial] += currMatQty;
                }
            }
        }

        static void PrintResults(Dictionary<string, int> keyMaterials, 
            Dictionary<string,int> junk,
            string itemObtained)
        {
            Console.WriteLine($"{itemObtained} obtained!");

            foreach (var item in keyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }

}


