using System;
using System.Collections.Generic;
using System.Linq;

class ActionPrint
{

    //Create a program that reads a collection of strings from the console and then prints them onto the console.
    //Each name should be printed on a new line.Use Action<T>.

    static void Main()
    {
        Action<string> printWords = word => Console.WriteLine(word);

        List<string> input = Console.ReadLine().Split(' ').ToList();

        input.ForEach(printWords);
    }
}
