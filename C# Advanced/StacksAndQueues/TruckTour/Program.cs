using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] pumps = new int[N];

            for (int i = 0; i < N; i++)
            {
                int[] details = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumps[i] = details[0] - details[1];
            }

            int currPump = 0;
            int position = 0;

            for (int i = 0; i < N; i++)
            {
                currPump += pumps[i];

                if (currPump < 0)
                {
                    currPump = 0;
                    position = i + 1;
                }
            }
            Console.WriteLine(position);
        }
    }
}
