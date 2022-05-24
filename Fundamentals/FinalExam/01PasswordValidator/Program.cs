using System;

namespace _01PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Complete")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "Validation")
                {
                    if (!IsLognEnough(password))
                    {
                        Console.WriteLine("Password must be at least 8 characters long!");
                    }

                    if (!ConsistsOfTheCorrectSymbols(password))
                    {
                        Console.WriteLine("Password must consist only of letters, digits and _!");
                    }

                    if (!ContainsUpperCase(password))
                    {
                        Console.WriteLine("Password must consist at least one uppercase letter!");
                    }

                    if (!ContainsLowerCase(password))
                    {
                        Console.WriteLine("Password must consist at least one lowercase letter!");
                    }

                    if (!ContainsAtLeastOneDigit(password))
                    {
                        Console.WriteLine("Password must consist at least one digit!");
                    }
                    command = Console.ReadLine();
                    continue;
                }

                if (cmdArgs[1] == "Upper")
                {
                    int indexToUpper = int.Parse(cmdArgs[2]);
                    string letterToReplace = password.Substring(indexToUpper, 1).ToUpper();
                    password = password.Remove(indexToUpper, 1);
                    password = password.Insert(indexToUpper, letterToReplace);
                    Console.WriteLine(password);
                }
                else if (cmdArgs[1] == "Lower")
                {
                    int indexToLower = int.Parse(cmdArgs[2]);
                    string letterToReplace = password.Substring(indexToLower, 1).ToLower();
                    password = password.Remove(indexToLower, 1);
                    password = password.Insert(indexToLower, letterToReplace);
                    Console.WriteLine(password);
                }
                else if (cmdArgs[0] == "Insert")
                {
                    int indexToInsert = int.Parse(cmdArgs[1]);
                    if (indexToInsert >= 0 || indexToInsert < password.Length)
                    {
                        string charToInsert = cmdArgs[2].ToString();
                        password = password.Insert(indexToInsert, charToInsert);
                        Console.WriteLine(password);

                        //command = Console.ReadLine();
                        //continue;
                    }


                }
                else if (cmdArgs[0] == "Replace")
                {
                    char currChar = char.Parse(cmdArgs[1]);
                    if (password.Contains(currChar))
                    {
                        int value = int.Parse(cmdArgs[2]);
                        int charValue = (int)currChar;
                        string charToReplace = cmdArgs[1].ToString();
                        int newCharInt = charValue + value;
                        char newChar = (char)newCharInt;

                        password = password.Replace(charToReplace, newChar.ToString());
                        Console.WriteLine(password);
                    }
                }
                command = Console.ReadLine();
            }
        }

        static bool ContainsAtLeastOneDigit(string password)
        {
            char[] chars = password.ToCharArray();
            foreach (char symbol in chars)
            {
                if (char.IsDigit(symbol))
                {
                    return true;
                }
            }

            return false;
        }

        static bool ContainsLowerCase(string password)
        {
            char[] chars = password.ToCharArray();
            foreach (char symbol in chars)
            {
                if (!char.IsUpper(symbol) && char.IsLetter(symbol))
                {
                    return true;
                }
            }

            return false;
        }

        static bool ContainsUpperCase(string password)
        {
            char[] chars = password.ToCharArray();
            foreach (char symbol in chars)
            {
                if (char.IsUpper(symbol))
                {
                    return true;
                }
            }
            return false;
        }

        static bool ConsistsOfTheCorrectSymbols(string password)
        {

            char[] chars = password.ToCharArray();
            foreach (char symbol in chars)
            {
                if (!char.IsLetterOrDigit(symbol) && symbol != '_' || char.IsWhiteSpace(symbol))
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsLognEnough(string password)
        {
            if (password.Length >= 8)
            {
                return true;
            }

            return false;
        }
    }
}
