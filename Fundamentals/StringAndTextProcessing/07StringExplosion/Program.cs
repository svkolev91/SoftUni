using System;
using System.Text;

namespace _07StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            StringBuilder output = new StringBuilder();
            int bombPower = 0;

            for (int i = 0; i < inputStr.Length; i++)
            {
                char currChar = inputStr[i];


                if (currChar == '>')
                {
                    output.Append(currChar);

                    bombPower += int.Parse(inputStr[i + 1].ToString());
                }
                else
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                    }
                    else
                    {
                        output.Append(currChar);
                    }
                }
            }

            Console.WriteLine(output.ToString());
        }
    }
}
