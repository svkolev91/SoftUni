using System;
using System.Collections.Generic;

namespace _05SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            Dictionary<string, string> listOfUsersAndPlates = new Dictionary<string, string>(); 

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] currentCmd = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (currentCmd.Length == 3)
                {
                    string userName = currentCmd[1];
                    string licensePlate = currentCmd[2];

                    if (!listOfUsersAndPlates.ContainsKey(userName))
                    {
                        listOfUsersAndPlates[userName] = licensePlate;
                        Console.WriteLine($"{userName} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                }
                else
                {
                    string userName = currentCmd[1];

                    if (listOfUsersAndPlates.ContainsKey(userName))
                    {
                        listOfUsersAndPlates.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }
            }

            PrintResult(listOfUsersAndPlates);
        }

        static void PrintResult(Dictionary<string, string> listOfUsersAndPlates)
        {
            foreach (var item in listOfUsersAndPlates)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
