using System;
using System.Collections.Generic;
using System.Linq;

namespace _03P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Town> towns = new List<Town>();

            while (input != "Sail")
            {
                string[] inputArgs = input.Split("||", StringSplitOptions.RemoveEmptyEntries);

                string townName = inputArgs[0];
                int people = int.Parse(inputArgs[1]);
                int gold = int.Parse(inputArgs[2]);

                if (IsExisting(towns, townName))
                {
                    Town existingTown = towns.FirstOrDefault(town => town.Name == townName);

                    existingTown.People += people;
                    existingTown.Gold += gold;
                }
                else
                {
                    towns.Add(new Town(townName, people, gold));
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputEventsArg = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string nextEvent = inputEventsArg[0];
                string townName = inputEventsArg[1];
                int people = 0;
                int gold = 0;
                if (inputEventsArg.Length == 4)
                {
                    people = int.Parse(inputEventsArg[2]);
                    gold = int.Parse(inputEventsArg[3]);

                }
                else
                {
                    gold = int.Parse(inputEventsArg[2]);
                }
                Town currentTown = towns.FirstOrDefault(town => town.Name == townName);

                if (nextEvent == "Plunder")
                {
                    currentTown.People -= people;
                    currentTown.Gold -= gold;

                    Console.WriteLine($"{townName} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (currentTown.People <= 0 || currentTown.Gold <= 0)
                    {
                        towns.Remove(currentTown);
                        Console.WriteLine($"{townName} has been wiped off the map!");
                    }

                }
                else if (nextEvent == "Prosper")
                {
                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        currentTown.Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {townName} now has {currentTown.Gold} gold.");
                    }
                }
                input = Console.ReadLine();
            }

            if (towns.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
                foreach (var town in towns)
                {
                    Console.WriteLine($"{town.Name} -> Population: {town.People} citizens, Gold: {town.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }

        static bool IsExisting(List<Town> towns, string townName)
        {
            foreach (Town town in towns)
            {
                if (town.Name == townName)
                {
                    return true;
                }
            }
            return false;
        }
    }


    class Town
    {
        public Town(string name, int people, int gold)
        {
            this.Name = name;
            this.People = people;
            this.Gold = gold;
        }

        public string Name { get; set; }

        public int People { get; set; }

        public int Gold { get; set; }
    }

    class ListOfTowns
    {

        public ListOfTowns()
        {
            this.listOfTowns = new List<Town>();
        }

        public List<Town> listOfTowns { get; set; }
    }
}
