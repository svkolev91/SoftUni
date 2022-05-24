using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            decimal totalIncome = 0m;

            string pattern = @"\%(?<client>[A-Z]{1}[a-z]+)\%[^%$|.]*?\<(?<product>\w+)\>[^%$|.]*?\|(?<count>\d+)\|[^%$|.]*?(?<price>\d+(\.\d+)?)\$";

            while (input != "end of shift")
            {

                Match validInfo = Regex.Match(input, pattern);

                if (validInfo.Success)
                {
                    string customer = validInfo.Groups["client"].Value;
                    string product = validInfo.Groups["product"].Value;
                    int count = int.Parse(validInfo.Groups["count"].Value);
                    decimal price = decimal.Parse(validInfo.Groups["price"].Value);
                    decimal total = price * (decimal)count;
                    Console.WriteLine($"{customer}: {product} - {total:f2}");
                    totalIncome += total;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
