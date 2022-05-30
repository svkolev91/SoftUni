using System;
using System.Collections.Generic;
using System.Linq;

class ProductShop
{

    //Create a program that prints information about food shops in Sofia and the products they store.Until the "Revision" command is received, you will be receiving input in the format: "{shop}, {product}, {price}". Keep in mind that if you receive a shop you already have received, you must collect its product information.

    //Your output must be ordered by shop name and must be in the format:

    //"{shop}->
    //Product: {product}, Price: {price}"

    static void Main()
    {
        var shops = new Dictionary<string, Dictionary<string, double>>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "Revision")
            {

                break;
            }

            string[] details = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string shop = details[0];
            string product = details[1];
            double price = double.Parse(details[2]);

            AddDetails(shops, shop, product, price);
        }
        Print(shops);
    }

    static void Print(Dictionary<string, Dictionary<string, double>> shops)
    {
        foreach (var item in shops.OrderBy(shop => shop.Key))
        {
            string shopName = item.Key;
            var products = item.Value;

            Console.WriteLine(shopName + "->");
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
            }

        }
    }

    static void AddDetails(Dictionary<string, Dictionary<string, double>> shops,
        string shop, string product, double price)
    {
        if (!shops.ContainsKey(shop))
        {
            shops[shop] = new Dictionary<string, double>()
            {
                {product, price},
            };
        }
        else
        {
            if (!shops[shop].ContainsKey(product))
            {
                shops[shop][product] = price;
            }

        }
    }
}

