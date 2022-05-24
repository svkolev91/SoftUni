using System;
using System.Text.RegularExpressions;

namespace _02FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBarcodes = int.Parse(Console.ReadLine());
            string pattern = @"\@\#+([A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1})\@\#+";

            for (int i = 0; i < numberOfBarcodes; i++)
            {
                string currBarcode = Console.ReadLine();

                Match match = Regex.Match(currBarcode, pattern);

                if (match.Success)
                {
                    string productGroup = string.Empty;
                    char[] charactersArr = currBarcode.ToCharArray();
                    foreach (char symbol in charactersArr)
                    {
                        if(char.IsDigit(symbol))
                        {
                            productGroup += symbol.ToString();
                        }
                    }

                    if (productGroup == string.Empty)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {productGroup}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }
        }
    }
}
