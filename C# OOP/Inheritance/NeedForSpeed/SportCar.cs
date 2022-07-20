namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public const double DefaultSportCarFuelConsumption = 10;
        public SportCar(int horsePower, double fuel) 
            : base(horsePower, fuel, DefaultSportCarFuelConsumption)
        {
        }
    }
}
