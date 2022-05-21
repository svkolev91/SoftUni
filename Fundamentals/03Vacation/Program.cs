using System;

namespace _03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var dayOfTheWeek = Console.ReadLine();
            double pricePerPerson = 0;
            double totalPrice = 0;

            switch (dayOfTheWeek)
            {
                case "Friday":                  
                    if (type == "Students")
                    {
                        pricePerPerson = 8.45;
                        totalPrice = people * pricePerPerson;
                        if (people >= 30) 
                        {
                            var discount = totalPrice * 0.15;
                            totalPrice -= discount;
                        }
                    }
                    else if (type == "Business")
                    {
                        pricePerPerson = 10.90;
                        totalPrice = people * pricePerPerson;
                        if (people >= 100)
                        {
                            people -= 10;
                            totalPrice = people * pricePerPerson;
                        }
                    }
                    else if (type == "Regular")
                    {
                        pricePerPerson = 15;
                        totalPrice = people * pricePerPerson;
                        if (people >= 10 && people <= 20)
                        {
                            var discount = totalPrice * 0.05;
                            totalPrice -= discount;
                        }
                    }

                    break;
                case "Saturday":
                    if (type == "Students")
                    {
                        pricePerPerson = 9.80;
                        totalPrice = people * pricePerPerson;
                        if (people >= 30)
                        {
                            var discount = totalPrice * 0.15;
                            totalPrice -= discount;
                        }
                    }
                    else if (type == "Business")
                    {
                        pricePerPerson = 15.60;
                        totalPrice = people * pricePerPerson;
                        if (people >= 100)
                        {
                            people -= 10;
                            totalPrice = people * pricePerPerson;
                        }
                    }
                    else if (type == "Regular")
                    {
                        pricePerPerson = 20;
                        totalPrice = people * pricePerPerson;
                        if (people >= 10 && people <= 20)
                        {
                            var discount = totalPrice * 0.05;
                            totalPrice -= discount;
                        }
                    }
                    break;
                case "Sunday":
                    if (type == "Students")
                    {
                        pricePerPerson = 10.46;
                        totalPrice = people * pricePerPerson;
                        if (people >= 30)
                        {
                            var discount = totalPrice * 0.15;
                            totalPrice -= discount;
                        }
                    }
                    else if (type == "Business")
                    {
                        pricePerPerson = 16;
                        totalPrice = people * pricePerPerson;
                        if (people >= 100)
                        {
                            people -= 10;
                            totalPrice = people * pricePerPerson;
                        }
                    }
                    else if (type == "Regular")
                    {
                        pricePerPerson = 22.50;
                        totalPrice = people * pricePerPerson;
                        if (people >= 10 && people <= 20)
                        {
                            var discount = totalPrice * 0.05;
                            totalPrice -= discount;
                        }
                    }

                    break;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
