using System;
using System.Collections.Generic;
using System.Linq;

class CitiesByContinentAndCountry
{

    //Create a program that reads continents, countries and their cities put them in a nested dictionary and prints them.

    static void Main()
    {
        int cycle = int.Parse(Console.ReadLine());

        var continents = new Dictionary<string, Dictionary<string, List<string>>>();

        for (int i = 0; i < cycle; i++)
        {
            string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string continent = input[0];
            string country = input[1];
            string city = input[2];

            AddCities(continents, continent, country, city);
        }

        PrintResults(continents);
    }

    static void PrintResults(Dictionary<string, Dictionary<string, List<string>>> continents)
    {
        foreach (string continent in continents.Keys)
        {
            Console.WriteLine($"{continent}:");

            foreach (string country in continents[continent].Keys)
            {
                Console.WriteLine($"  {country} -> {string.Join(", ", continents[continent][country])}");
            }
        }
    }

    static void AddCities(Dictionary<string, Dictionary<string, List<string>>> continents, 
        string continent, string country, string city)
    {
        if (!continents.ContainsKey(continent))
            continents.Add(continent, new Dictionary<string, List<string>>());
        
        
        if (!continents[continent].ContainsKey(country))
            continents[continent].Add(country, new List<string>());
            
        continents[continent][country].Add(city);
    }
}

