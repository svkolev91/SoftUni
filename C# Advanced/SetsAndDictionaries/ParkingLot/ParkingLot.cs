using System;
using System.Collections.Generic;

class ParkingLot
{
    //   Create a program that:

    //      · Records a car number for every car that enters the parking lot.

    //      · Removes a car number when the car leaves the parking lot.

    //  The input will be a string in the format: "direction, carNumber". You will be receiving commands until the "END" command is given.

    //  Print the car numbers of the cars, which are still in the parking lot.

    static void Main()
    {
         HashSet<string> carsSet = new HashSet<string>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "END")
            {
                if (carsSet.Count > 0)
                {
                    foreach (string plate in carsSet)
                    {
                        Console.WriteLine(plate);
                    }
                }
                else
                {
                    Console.WriteLine("Parking Lot is Empty");
                }
                
                break;
            }
            string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

            if (tokens[0] == "IN")
            {
                carsSet.Add(tokens[1]);
            }
            else if (tokens[0] == "OUT")
            {
                carsSet.Remove(tokens[1]);
            }
        }
    }
}
