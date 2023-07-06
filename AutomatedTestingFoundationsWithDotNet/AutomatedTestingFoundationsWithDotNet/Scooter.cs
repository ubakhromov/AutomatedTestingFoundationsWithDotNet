namespace AutomatedTestingFoundationsWithDotNet
{
    public class Scooter : Vehicle
    {
        public string Brand { get; set; }
        public int MaxSpeed { get; set; }

        public Scooter(string brand, 
            int maxSpeed, 
            Engine engine,
            Chassis chassis,
            Transmission transmission)
                : base(engine, chassis, transmission)
        {
            Brand = brand;
            MaxSpeed = maxSpeed;
        }
    }
}
