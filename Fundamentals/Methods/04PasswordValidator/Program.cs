using System;

namespace _04PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool resultLengthCheck = CheckLength(password);
            bool resultCharactersCheck = ContainsOnlyLettersAndDigits(password);
            bool resultAtLeastTwoDigitsCheck = ContainsAtLeastTwoDigits(password);
            
            if (resultLengthCheck && resultCharactersCheck && resultAtLeastTwoDigitsCheck)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!resultLengthCheck)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!resultCharactersCheck)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!resultAtLeastTwoDigitsCheck)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        static bool CheckLength(string password)
        {
            bool result = false;

            if (password.Length >=6 && password.Length <= 10)
            {
                result = true;
            }
            return result;
        }

        static bool ContainsOnlyLettersAndDigits(string password)
        {
            bool result = false;

            foreach (char ch in password.ToLower())
            {
                if ((int)ch >= 48 && (int)ch <= 57 || (int)ch >= 97 && (int)ch <= 122)
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        static bool ContainsAtLeastTwoDigits(string password)
        {
            bool result = false;
            int digitsCounter = 0;

            foreach (char ch in password.ToLower())
            {
                if ((int)ch >= 48 && (int)ch <= 57)
                {
                    digitsCounter++;
                }
            }

            if (digitsCounter >= 2)
            {
                result = true;
            }

            return result;
        }
    }
}
