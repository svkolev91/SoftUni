using System;
using System.Linq;

namespace _04PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] stringArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (stringArgs[0] == "TakeOdd")
                {
                    string newString = string.Empty;
                    for (int i = 1; i < firstInput.Length; i+= 2)
                    {
                        newString += firstInput[i];
                    }
                    firstInput = newString;
                    Console.WriteLine(firstInput);
                }
                else if (stringArgs[0] == "Cut")
                {
                    int index = int.Parse(stringArgs[1]);
                    int length = int.Parse(stringArgs[2]);

                    //string subString = input.Substring(index, length);
                    firstInput = firstInput.Remove(index, length);
                    Console.WriteLine(firstInput);
                }
                else if (stringArgs[0] == "Substitute")
                {
                    string subString = stringArgs[1];
                    string substitute = stringArgs[2];
                    if (firstInput.Contains(subString))
                    {
                        firstInput = firstInput.Replace(subString, substitute);
                        Console.WriteLine(firstInput);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                        
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {firstInput}");
        }
    }
}
