using System;
using System.Collections.Generic;
using System.Linq;

class Wardrobe
{

    //   Create a program that helps you decide what clothes to wear from your wardrobe.
    //   You will receive the clothes, which are currently in your wardrobe, sorted by their color in the following format:
    //  "{color} -> {item1},{item2},{item3}…"

    //  If you receive a certain color, which already exists in your wardrobe, just add the clothes to its records.
    //  You can also receive repeating items for a certain color and you have to keep their count.
    //  In the end, you will receive a color and a piece of clothing, which you will look for in the wardrobe,
    //  separated by a space in the following format:
    //  "{color} {clothing}"

    //  Your task is to print all the items and their count for each color in the following format: 
    //  "{color} clothes:
    //  * {item1} - {count}
    //  * {item2} - {count}
    //  * {item3} - {count}
    //  …
    //  * {itemN} - {count}"

    //  If you find the item you are looking for, you need to print "(found!)" next to it:
    //  "* {itemN} - {count} (found!)"

    //  Input
    //      •	On the first line, you will receive n - the number of lines of clothes, which you will receive.
    //      •	On the next n lines, you will receive the clothes in the format described above.

    //  Output
    //      •	Print the clothes from your wardrobe in the format described above.


    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var wardrobe = new Dictionary<string, Dictionary<string, int>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

            string color = input[0];
            string[] clothing = input[1].Split(",",StringSplitOptions.RemoveEmptyEntries);

            AddClothing(wardrobe, color, clothing);

        }

        string[] clothesForTheDay = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string dailyColor = clothesForTheDay[0];
        string dailyClothing = clothesForTheDay[1];

        Printing(wardrobe, dailyColor, dailyClothing);

    }

    static void AddClothing(Dictionary<string, Dictionary<string, int>> wardrobe, string color, string[] clothing)
    {
        if (!wardrobe.ContainsKey(color))
        {
            wardrobe.Add(color, new Dictionary<string, int>());
        }

        foreach (string c in clothing)
        {
            if (!wardrobe[color].ContainsKey(c))
            {
                wardrobe[color].Add(c, 0);
            }
            wardrobe[color][c]++;
        }

    }

    static void Printing(Dictionary<string, Dictionary<string, int>> wardrobe, string dailyColor, string dailyClothing)
    {
        foreach (string color in wardrobe.Keys)
        {
            Console.WriteLine($"{color} clothes:");

            foreach (string clothing in wardrobe[color].Keys)
            {
                int value = wardrobe[color][clothing];
                //string cloth = wardrobe[color].ToString();
                if (dailyColor == color && dailyClothing == clothing)
                {
                    Console.WriteLine($"* {clothing} - {value} (found!)");
                }
                else
                {
                    Console.WriteLine($"* {clothing} - {value}");
                }
            }
        }
    }
}
