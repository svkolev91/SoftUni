using System;
using System.Collections.Generic;

class UniqueUsernames
{

    //Create a program that reads from the console a sequence of N usernames and keeps a collection only of the unique ones.
    //On the first line, you will be given an integer N.On the next N lines, you will receive one username per line.
    //Print the collection on the console in order of insertion:

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        HashSet<string> users = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            string username = Console.ReadLine();
            if (!users.Contains(username))
            {
                users.Add(username);
            }
        }

        foreach (string user in users)
        {
            Console.WriteLine(user);
        }
    }
}

