using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    internal class SpeedRacing
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carDetails = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = carDetails[0];
                foreach (var car in cars)
                {
                    if (car.Model == carModel)
                    {
                        continue;
                    }
                }

                double carFuel = double.Parse(carDetails[1]);
                double carConsumption = double.Parse(carDetails[2]);

                Car currentCar = new Car(carModel, carFuel, carConsumption);

                

                cars.Add(currentCar);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string carModel = input.Split(" ")[1];
                double kmToMove = double.Parse(input.Split(" ")[2]);

                cars.First(car => car.Model == carModel).CarMove(kmToMove);

                input = Console.ReadLine();
            }

            PrintCars(cars);
        }

        private static void PrintCars(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
