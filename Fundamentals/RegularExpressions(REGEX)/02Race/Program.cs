using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] validRacers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> racersArr = new List<string>();
            foreach (string racer in validRacers)
            {
                racersArr.Add(racer);
            }    


            string input = Console.ReadLine();
            int distance = 0;
            SortedDictionary<string, int> listOfRacersAndDistances = new SortedDictionary<string, int>();

            while (input != "end of race")
            {
                StringBuilder currRacerName = new StringBuilder();
                char[] chars = input.ToCharArray();

                foreach (char letter in chars)
                {
                    if (Char.IsDigit(letter))
                    {
                        distance += int.Parse(letter.ToString());
                    }
                    else if (char.IsLetter(letter))
                    {
                        currRacerName.Append(letter.ToString());
                    }
                }

                if (racersArr.Contains(currRacerName.ToString()))
                {

                    if (!listOfRacersAndDistances.ContainsKey(currRacerName.ToString()))
                    {
                        listOfRacersAndDistances.Add(currRacerName.ToString(), distance);
                    }
                    else
                    {
                        listOfRacersAndDistances[currRacerName.ToString()] += distance;
                    }
                }


                distance = 0;
                input = Console.ReadLine();
            }

            List<string> sortedRacers = listOfRacersAndDistances.OrderByDescending(x => x.Value).Select(x => x.Key).Take(3).ToList();


            Console.WriteLine($"1st place: {sortedRacers[0]}");
            Console.WriteLine($"2nd place: {sortedRacers[1]}");
            Console.WriteLine($"3rd place: {sortedRacers[2]}");
        }
    }
}
