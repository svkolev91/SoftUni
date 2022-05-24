using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            decimal totalPrice = 0m;
            string regexPattern = @">>(?<item>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";
            List<string> listOfItems = new List<string>();


            while (inputStr != "Purchase")
            {
                //bool isValid = Regex.IsMatch(inputStr, regexPattern);
                Match validInfo = Regex.Match(inputStr, regexPattern);
                if (validInfo.Success)
                {
                    
                    listOfItems.Add(validInfo.Groups["item"].Value);
                    decimal currPrice = decimal.Parse(validInfo.Groups["price"].Value);
                    int currQuantity = int.Parse(validInfo.Groups["quantity"].Value);
                    totalPrice += currPrice * currQuantity;
                }

                inputStr = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            foreach (var item in listOfItems)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
