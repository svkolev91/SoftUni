using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> productsAndQty = new Dictionary<string, int>();

            string inputCmd = Console.ReadLine();

            List<Product> products = new List<Product>();


            while (inputCmd != "buy")
            {
                string[] detailsArr = inputCmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currntProduct = detailsArr[0];
                double currntProductPrice = double.Parse(detailsArr[1]);
                int currntProductQty = int.Parse(detailsArr[2]);



                if (DoesProductExist(products,currntProduct))
                {
                    Product existingProduct = GetExistingProduct(products, currntProduct);

                    if (existingProduct.Price != currntProductPrice)
                    {
                        existingProduct.Price = currntProductPrice;
                    }

                    existingProduct.Quantity += currntProductQty;
                }
                else
                {
                    products.Add(new Product(currntProduct, currntProductPrice, currntProductQty));
                }

                inputCmd = Console.ReadLine();
            }

            PrintResults(products);

        }

        static void PrintResults(List<Product> products)
        {
            foreach (Product product in products)
            {
                double totalPrice = product.Price * product.Quantity;
                Console.WriteLine($"{product.Name} -> {totalPrice:f2}");
            }
        }

        static Product GetExistingProduct(List<Product> products, string currntProduct)
        {

            foreach (var product in products)
            {
                if (product.Name == currntProduct)
                {
                    return product;
                }
            }

            return null;
        }

        static bool DoesProductExist(List<Product> products, string currntProduct)
        {
            foreach (var product in products)
            {
                if (product.Name == currntProduct)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class Product
    {
        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public int Quantity { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

    }
}
