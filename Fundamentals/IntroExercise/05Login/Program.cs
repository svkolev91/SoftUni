using System;

namespace _05Login
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();
            var counter = 0;
            var pass = string.Empty;
            var input = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                pass += username[i]; 
            }

            input = Console.ReadLine();

            while (input != pass)
            {
                
                counter++;

                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
            }

            if (input == pass)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
