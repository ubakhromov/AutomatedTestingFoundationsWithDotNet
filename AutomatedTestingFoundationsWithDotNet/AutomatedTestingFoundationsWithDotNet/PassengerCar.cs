namespace AutomatedTestingFoundationsWithDotNet
{
    public class PassengerCar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public Transmission Transmission { get; set; }

        public PassengerCar(string brand, string model, Engine engine, Chassis chassis, Transmission transmission)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }

        public override string ToString()
        {
            return $"Passenger Car:\nBrand: {Brand}\nModel: {Model}\n{Engine}\n{Chassis}\n{Transmission}";
        }
    }
}
