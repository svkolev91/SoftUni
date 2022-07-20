namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public const double DefaultCarFuelConsumption = 3;
        public Car(int horsePower, double fuel, double fuelConsumption = DefaultCarFuelConsumption) 
            : base(horsePower, fuel, fuelConsumption)
        {
        }
    }
}
