using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isBalanced = false;
            Stack<char> openingBrackets = new Stack<char>();

            foreach (var symbol in input)
            {
                if (symbol == '[' || symbol == '{' || symbol == '(')
                {
                    openingBrackets.Push(symbol);
                }
                else if (symbol == ']' || symbol == ')' || symbol == '}')
                {
                    if (openingBrackets.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }

                    char lastSymbol = openingBrackets.Pop();

                    if (lastSymbol == '[' && symbol == ']')
                    {
                        isBalanced = true;
                    }
                    else if (lastSymbol == '{' && symbol == '}')
                    {
                        isBalanced = true;
                    }
                    else if (lastSymbol == '(' && symbol == ')')
                    {
                        isBalanced = true;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            
        }
    }
}
