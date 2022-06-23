using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input1 = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int[] input2 = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Queue<int> steel = new Queue<int>(input1);
        Stack<int> carbon = new Stack<int>(input2);
        Dictionary<string, int> swords = new Dictionary<string, int>();
        int craftedSwordsCount = 0;

        while (steel.Count > 0 && carbon.Count > 0)
        {

            int currentSteel = steel.Dequeue();
            int currentCarbon = carbon.Pop();
            int currentMixture = currentSteel + currentCarbon;
            string sword = string.Empty;

            if(string.IsNullOrEmpty(CheckIfSwordCanBeCrafter(currentMixture)))
            {
                carbon.Push(currentCarbon + 5);
            }
            else
            {
                sword = CheckIfSwordCanBeCrafter(currentMixture);
                if (!swords.ContainsKey(sword))
                {
                    swords.Add(sword, 0);
                }
                swords[sword]++;
                craftedSwordsCount++;
            }
        }

        if (craftedSwordsCount == 0)
        {
            Console.WriteLine("You did not have enough resources to forge a sword.");
        }
        else
        {
            Console.WriteLine($"You have forged {craftedSwordsCount} swords.");
        }

        PrintSteelAndCarbonLeft(steel,carbon);

        foreach (var sword in swords.OrderBy(s => s.Key))
        {
            Console.WriteLine($"{sword.Key}: {sword.Value}");
        }
    }


    private static string CheckIfSwordCanBeCrafter(int currentMixture)
    {
        string sword = string.Empty;
        if (currentMixture == 70)
        {
            sword = "Gladius";
        }
        else if (currentMixture == 80)
        {
            sword = "Shamshir";
        }
        else if (currentMixture == 90)
        {
            sword = "Katana";
        }
        else if (currentMixture == 110)
        {
            sword = "Sabre";
        }
        else if (currentMixture == 150)
        {
            sword = "Broadsword";
        }

        return sword;
        
    }

    private static void PrintSteelAndCarbonLeft(Queue<int> steel, Stack<int> carbon)
    {
        Console.Write("Steel left: ");
        if (steel.Count > 0)
        {
            Console.WriteLine(string.Join(", ", steel));
        }
        else
        {
            Console.WriteLine("none");
        }

        Console.Write("Carbon left: ");
        if (carbon.Count > 0)
        {
            Console.WriteLine(string.Join(", ", carbon));
        }
        else
        {
            Console.WriteLine("none");
        }
    }
}
