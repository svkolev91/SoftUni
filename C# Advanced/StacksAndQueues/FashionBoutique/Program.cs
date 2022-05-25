using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            int rackCap = int.Parse(Console.ReadLine());
            int numberOfRacks = 1;
            int currRack = 0;

            while (clothes.Count > 0)
            {
                if (clothes.Peek() + currRack <= rackCap)
                {
                    currRack += clothes.Pop();
                }
                else if(clothes.Peek() + currRack > rackCap)
                {
                    numberOfRacks++;
                    currRack = clothes.Pop();
                }
            }
            Console.WriteLine(numberOfRacks);
        }
    }
}
