using System;

namespace _07VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            double sum = 0;


            while (input != "Start")
            {
                var coins = double.Parse(input);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                var price = 0.0;
                switch (input)
                {
                    case "Nuts":
                        price = 2.0;
                        if (sum >= price)
                        {
                            Console.WriteLine($"Purchased nuts");
                            sum -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        price = 0.7;
                        if (sum >= price)
                        {
                            Console.WriteLine($"Purchased water");
                            sum -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        price = 1.5;
                        if (sum >= price)
                        {
                            Console.WriteLine($"Purchased crisps");
                            sum -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        price = 0.8;
                        if (sum >= price)
                        {
                            Console.WriteLine($"Purchased soda");
                            sum -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        price = 1.0;
                        if (sum >= price)
                        {
                            Console.WriteLine($"Purchased coke");
                            sum -= price;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
