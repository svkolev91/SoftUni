namespace NeedForSpeed
{
    public class Vehicle
    {
        public const double DefaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel, double fuelConsumption = DefaultFuelConsumption)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
            this.FuelConsumption = fuelConsumption;
        }
        
        public int HorsePower { get; set; }
        public double Fuel { get; set; }

        public virtual double FuelConsumption { get; set; }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= kilometers * this.FuelConsumption; 
        }

    }
}
