namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public const double DefaultRaceMotorcycleFuelConsumption = 8;
        public RaceMotorcycle(int horsePower, double fuel) 
            : base(horsePower, fuel, DefaultRaceMotorcycleFuelConsumption)
        {
        }
    }
}
