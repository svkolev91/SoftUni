
namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            string[] personInput = Console.ReadLine().Split(";");

            try
            {
                for (int i = 0; i < personInput.Length; i++)
                {
                    string[] currentPersonArgs = personInput[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                    string personName = currentPersonArgs[0];
                    int personMoney = int.Parse(currentPersonArgs[1]);

                    Person person = new Person(personName, personMoney);
                    people.Add(person);
                }

                string[] productsInput = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);
                List<Product> products = new List<Product>();

                for (int i = 0; i < productsInput.Length; i++)
                {
                    string[] currentProductArgs = productsInput[i].Split("=",StringSplitOptions.RemoveEmptyEntries);
                    string productName = currentProductArgs[0];
                    int productCost = int.Parse(currentProductArgs[1]);

                    Product product = new Product(productName, productCost);
                    products.Add(product);
                }

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] cmdArgs = command.Split(" ");

                    string person = cmdArgs[0];
                    string product = cmdArgs[1];

                    Product currentProduct = products.FirstOrDefault(p => p.Name == product);
                    Person currentPerson = people.FirstOrDefault(p => p.Name == person);

                    try
                    {
                        currentPerson.AddProduct(currentProduct);
                        Console.WriteLine($"{person} bought {product}");
                    }
                    catch (Exception ae)
                    {
                        Console.WriteLine(ae.Message);
                    }

                    command = Console.ReadLine();
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }


            if (people.Count > 0)
            {
                foreach (Person person in people)
                {
                    Console.WriteLine($"{person.Name} - {person.BagOfProducts(person)}");
                }
            }
            
        }
    }
}
