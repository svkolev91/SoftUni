using System;
using System.Collections.Generic;

class RecordUniqueNames
{

    //Create a program, which will take a list of names and print only the unique names in the list.

    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        HashSet<string> set = new HashSet<string>();

        for (int i = 0; i < num; i++)
        {
            string name = Console.ReadLine();
            set.Add(name); 
        }

        foreach (string name in set)
        {
            Console.WriteLine(name);
        }
    }
}
