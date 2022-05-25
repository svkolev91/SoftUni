using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "1")
                {

                    stack.Push(text);
                    text += cmdArgs[1];
                }
                else if (cmdArgs[0] == "2")
                {
                    int count = int.Parse(cmdArgs[1]);

                    stack.Push(text);
                    text = text.Remove(text.Length - count);
                }
                else if (cmdArgs[0] == "3")
                {
                    int charIndex = int.Parse(cmdArgs[1]);
                    char letter = text[charIndex - 1];
                    Console.WriteLine(letter);
                }
                else
                {
                    text = stack.Pop();
                }
            }

        }
    }
}
