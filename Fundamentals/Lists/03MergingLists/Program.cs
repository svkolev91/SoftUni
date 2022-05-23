﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            List<int> secondList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int longestList = Math.Max(firstList.Count, secondList.Count);  
            
            List<int> result = new List<int>();

            for (int i = 0; i < longestList; i++)
            {
                if (firstList.Count > i)
                {
                    result.Add(firstList[i]);
                }

                if (secondList.Count > i)
                {
                    result.Add(secondList[i]);
                }
            }


            Console.WriteLine(string.Join(" ", result));
        }
    }
}
