using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> queue = new Queue<string>(songs);

            while (queue.Count > 0)
            {
                string cmd = Console.ReadLine();

                if (cmd == "Play")
                {
                    queue.Dequeue();
                }
                else if (cmd == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                else
                {
                    string songName = cmd.Substring(4);

                    if (queue.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(songName);
                    }
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
