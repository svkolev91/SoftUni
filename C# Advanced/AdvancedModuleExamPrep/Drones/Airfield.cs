using System;
using System.Collections.Generic;
using System.Linq;

namespace Drones
{
    public class Airfield
    {
        public List<Drone> Drones { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }

        public Airfield(string name, int capacity, double landingStrip)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.LandingStrip = landingStrip;
            this.Drones = new List<Drone>();
        }

        public int Count => this.Drones.Count;

        public string AddDrone (Drone drone)
        {
            if (string.IsNullOrEmpty(drone.Name) || string.IsNullOrEmpty(drone.Brand) || drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone";
            }
            
            if(this.Drones.Count >= this.Capacity)
            {
                return "Airfield is full.";
            }

            Drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }

        public bool RemoveDrone(string name)
        {
            foreach (var drone in Drones)
            {
                if (drone.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public int RemoveDroneByBrand(string brand)
        {
            int count = 0;

            foreach (var drone in Drones)
            {
                if (drone.Brand == brand)
                {
                    count++;
                }
            }
            Drones.RemoveAll(d => d.Brand == brand);
            return count;
        }

        public Drone FlyDrone(string name)
        {
            foreach (var drone in Drones)
            {
                if (drone.Name == name)
                {
                    drone.Available = false;
                    return drone;
                }
            }

            return null;
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> drones = new List<Drone>();

            foreach (var drone in Drones)
            {
                if (drone.Range >= range)
                {
                    drone.Available = false;
                    drones.Add(drone);
                }
            }

            return drones;
        }

        public string Report()
        {
            var availableDrones = this.Drones.Where(d => d.Available == true);
            return
                $"Drones available at {this.Name}:" +
                string.Join(Environment.NewLine, availableDrones);
        }
    }
}
