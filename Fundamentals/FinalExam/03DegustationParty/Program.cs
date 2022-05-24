using System;
using System.Collections.Generic;

namespace _03DegustationParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> customers = new Dictionary<string, List<string>>();
            int dislikedMeals = 0;

            while (input != "Stop")
            {
                string[] cmdArgs = input.Split('-', StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                string guest = cmdArgs[1];
                string meal = cmdArgs[2];

                if (command == "Like")
                {
                    if (!customers.ContainsKey(guest))
                    {
                        customers.Add(guest, new List<string>() { meal });
                    }
                    else
                    {
                        if (customers[guest].Contains(meal))
                        {
                            input = Console.ReadLine();
                            continue;
                        }

                        customers[guest].Add(meal);
                    }
                }
                else if (command == "Dislike")
                {
                    if (!customers.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                        input = Console.ReadLine();

                        continue;
                    }

                    if (!customers[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                    else
                    {
                        customers[guest].Remove(meal);
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                        dislikedMeals++;
                    }
                }
                input = Console.ReadLine();

            }

            PrintResults(customers, dislikedMeals);
        }

        static void PrintResults(Dictionary<string, List<string>> customers, int dislikedMeals)
        {
            foreach (var customer in customers)
            {
                string name = customer.Key;
                List<string> meals = customer.Value;
                string mealsPrint = string.Join(", ", meals);

                Console.WriteLine($"{name}: {mealsPrint}");
                
            }
            Console.WriteLine($"Unliked meals: {dislikedMeals}");

        }
    }
}
