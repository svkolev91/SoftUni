using System;
using System.Collections.Generic;
using System.Linq;

class PredicateParty
{

    //Ivan's parents are on a vacation for the holidays and he is planning an epic party at home.
    //Unfortunately, his organizational skills are next to non-existent, so you are given the task
    //to help him with the reservations.

    //On the first line, you receive a list of all the people that are coming.
    //On the next lines, until you get the "Party!" command,
    //you may be asked to double or remove all the people that apply to the given criteria. There are three different criteria:
    //
    //•	Everyone that has his name starting with a given string
    //•	Everyone that has a name ending with a given string
    //•	Everyone that has a name with a given length

    //Finally, print all the guests who are going to the party
    //separated by ", " and then add the ending "are going to the party!".
    //If no guests are going to the party print "Nobody is going to the party!". 

    static void Main()
    {
        List<string> guests = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string command = Console.ReadLine();

        while (command != "Party!")
        {
            string[] args = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> predicated = GetPredicate(args);
            if (args[0] == "Double")
            {
                for(int i = 0; i < guests.Count; i++)
                {
                    string person = guests[i];
                    if (predicated(person))
                    {
                        guests.Insert(i + 1, person);
                        i ++;
                    }
                }
            }
            else if (args[0] == "Remove")
            {
                guests.RemoveAll(predicated);
            }

            command = Console.ReadLine();
        }

        if (guests.Count == 0)
        {
            Console.WriteLine("Nobody is going to the party!");
        }
        else
        {
            Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
        }

    }

    static Predicate<string> GetPredicate(string[] args)
    {
        string cmd = args[1];
        string arg = args[2];

        Predicate<string> predicate = null;
        if (cmd == "StartsWith")
        {
            predicate = name => name.StartsWith(arg);
        }
        else if (cmd == "EndsWith")
        {
            predicate = name => name.EndsWith(arg);

        }
        else if (cmd == "Length")
        {
            predicate = name => name.Length == int.Parse(arg);
        }
        return predicate;
    }
}
