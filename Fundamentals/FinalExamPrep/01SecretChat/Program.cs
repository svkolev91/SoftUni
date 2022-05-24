using System;

namespace _01SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();

            string currentInput = Console.ReadLine();

            while (currentInput != "Reveal")
            {
                string[] stringParams = currentInput
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string cmd = stringParams[0];

                if (cmd == "InsertSpace")
                {
                    int inserIndex = int.Parse(stringParams[1]);
                    firstInput = firstInput.Insert(inserIndex, " ");
                    Console.WriteLine(firstInput);
                }
                else if(cmd == "Reverse")
                {
                    string textToCut = stringParams[1];
                    char[] textToCutArr = stringParams[1].ToCharArray();
                    string newCut = string.Empty;
                    for (int i = textToCut.Length - 1; i >= 0; i--)
                    {
                        newCut += textToCut[i].ToString();
                    }
                    
                    if (firstInput.Contains(textToCut))
                    {
                        int indexToUse = firstInput.IndexOf(textToCut);
                        firstInput = firstInput.Remove(indexToUse, textToCut.Length);
                        firstInput += newCut;
                        Console.WriteLine(firstInput);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmd == "ChangeAll")
                {
                    string newInfo = stringParams[2];

                    firstInput = firstInput.Replace(stringParams[1], newInfo);
                    Console.WriteLine(firstInput);
                }

                currentInput = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {firstInput}");
        }
    }
}
