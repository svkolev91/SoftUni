using System;
using System.Collections.Generic;
using System.Linq;

class TilesMaster
{
    static void Main()
    {
        int[] tiles1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        Stack<int> whiteTiles = new Stack<int>(tiles1);

        int[] tiles2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        Queue<int> greyTiles = new Queue<int>(tiles2);


        SortedDictionary<string, int> tiles = new SortedDictionary<string, int>();
        

        while(whiteTiles.Count != 0 && greyTiles.Count != 0)
        {
            int currentWhiteTile = whiteTiles.Pop();
            int currentGreyTile = greyTiles.Dequeue();

            if (currentGreyTile == currentWhiteTile)
            {
                int newTile = currentWhiteTile + currentGreyTile;

                if (newTile > 70 || newTile < 40)
                {
                    if (!tiles.ContainsKey("Floor"))
                    {
                        tiles.Add("Floor", 0);
                    }
                    tiles["Floor"]++;
                }
                else if (newTile == 40)
                {
                    if (!tiles.ContainsKey("'Sink"))
                    {
                        tiles.Add("Sink", 0);
                    }
                    tiles["Sink"]++;
                }
                else if (newTile == 50)
                {
                    if (!tiles.ContainsKey("Oven"))
                    {
                        tiles.Add("Oven", 0);
                    }
                    tiles["Oven"]++;
                }
                else if (newTile == 60)
                {
                    if (!tiles.ContainsKey("Countertop"))
                    {
                        tiles.Add("Countertop", 0);
                    }
                    tiles["Countertop"]++;
                }
                else if (newTile == 70)
                {
                    if (!tiles.ContainsKey("Wall"))
                    {
                        tiles.Add("Wall", 0);
                    }
                    tiles["Wall"]++;
                }
            }
            else
            {
                whiteTiles.Push(currentWhiteTile / 2);
                greyTiles.Enqueue(currentGreyTile);
            }

            //if (whiteTiles.Count == 0 && greyTiles.Count == 0)
            //{
            //    break;
            //}
        }


        PrintResults(whiteTiles,greyTiles,tiles);
    }

    public static void PrintResults(Stack<int> whiteTiles, Queue<int> greyTiles, SortedDictionary<string, int> tiles)
    {
        Console.Write($"White tiles left: ");
        if (whiteTiles.Count == 0)
        {
            Console.WriteLine("none");
        }
        else
        {
            Console.WriteLine(string.Join(", ", whiteTiles));
        }

        Console.Write($"Grey tiles left: ");
        if (greyTiles.Count == 0)
        {
            Console.WriteLine("none");
        }
        else
        {
            Console.WriteLine(string.Join(", ", greyTiles));
        }

        foreach (var tile in tiles.OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"{tile.Key}: {tile.Value}");
        }
    }
}
