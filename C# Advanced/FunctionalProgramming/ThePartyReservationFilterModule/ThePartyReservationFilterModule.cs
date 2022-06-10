using System;
using System.Collections.Generic;
using System.Linq;

class ThePartyReservationFilterModule
{

    //You need to implement a filtering module to a party reservation software.
    //First, the Party Reservation Filter Module (PRFM for short) has been passed a list with invitations.
    //Next, the PRFM receives a sequence of commands that specify whether you need to add or remove a given filter.
    //Each PRFM command is in the given format:

    //"{command;filter type;filter parameter}"

    //You can receive the following PRFM commands: 

    //  •	"Add filter"
    //  •	"Remove filter"
    //  •	"Print" 

    //The possible PRFM filter types are: 

    //  •	"Starts with"
    //  •	"Ends with"
    //  •	"Length"
    //  •	"Contains"

    //All PRFM filter parameters will be a string (or an integer only for the "Length" filter).
    //Each command will be valid e.g.you won't be asked to remove a non-existent filter.
    //The input will end with a "Print" command, after which you should print all the party-goers
    //that are left after the filtration. 


    static void Main()
    {
        List<string> guests = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        List<string> backupGuests = new List<string>();

        foreach (var name in guests)
        {
            backupGuests.Add(name);
        }

        string command = Console.ReadLine();
        int indexRemoved = int.MinValue;

        while (command != "Print")
        {
            string[] cmdArgs = command.Split(";", StringSplitOptions.RemoveEmptyEntries);

            string filter = cmdArgs[1];
            string param = cmdArgs[2];
            Predicate<string> predicate = GetPredicate(filter, param);

            if (cmdArgs[0].StartsWith("Add filter"))
            {
                indexRemoved = guests.FindIndex(predicate);
                guests.RemoveAll(predicate);
            }
            else if (cmdArgs[0].StartsWith("Remove filter"))
            {
                guests.Insert(indexRemoved, backupGuests.Find(predicate));
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", guests));

    }

    static Predicate<string> GetPredicate(string filter, string param)
    {
        Predicate<string> predicate = null;

        if (filter == "Starts with")
        {
            predicate = name => name.StartsWith(param);
        }
        else if (filter == "Ends with")
        {
            predicate = name => name.EndsWith(param);

        }
        else if (filter == "Length")
        {
            predicate = name => name.Length == int.Parse(param);
        }
        else if (filter == "Contains")
        {
            predicate = name => name.Contains(param);
        }

        return predicate;
    }
}
