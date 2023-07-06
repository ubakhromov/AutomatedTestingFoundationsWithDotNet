namespace AutomatedTestingFoundationsWithDotNet
{
    public class Truck : Vehicle
    {
        public string Manufacturer { get; set; }
        public double CargoCapacity { get; set; }

        public Truck(string manufacturer, double cargoCapacity, Engine engine, Chassis chassis, Transmission transmission)
            : base(engine, chassis, transmission)
        {
            Manufacturer = manufacturer;
            CargoCapacity = cargoCapacity;
        }
    }
}
