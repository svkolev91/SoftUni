using System;
using System.Collections.Generic;

namespace _01AdvertisementMessage
{
    //class Advertisement
    //{
    //    public List<string> Phrases { get; set; }

    //    public List<string> Events { get; set; }

    //    public List<string> Authors { get; set; }

    //    public List<string> Cities { get; set; }

    //}


    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            List<string> phrases = new List<string>()
            {
                "Excellent product.",
                "Such a great product.", 
                "I always use that product.", 
                "Best product of its category.", 
                "Exceptional product.", 
                "I can’t live without this product."
            };

            List<string> events = new List<string>()
            { 
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            List<string> authors = new List<string>()
            { 
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            List<string> cities = new List<string>()
            { 
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            Random randomPhrase = new Random();
            Random randomEvent = new Random();
            Random randomAuthor = new Random();
            Random randomCity = new Random();



            for (int i = 0; i < numberOfMessages; i++)
            {
                Console.WriteLine($"{phrases[randomPhrase.Next(0,phrases.Count -1)]} {events[randomEvent.Next(0, events.Count -1)]} {authors[randomAuthor.Next(0,authors.Count - 1)]} – {cities[randomCity.Next(0, cities.Count - 1)]}.");

            }
        }
    }
}
