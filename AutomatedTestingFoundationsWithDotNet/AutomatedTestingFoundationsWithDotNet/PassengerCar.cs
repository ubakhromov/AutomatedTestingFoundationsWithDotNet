namespace AutomatedTestingFoundationsWithDotNet
{
    public class PassengerCar : Vehicle
    {
        public string Model { get; set; }
        public int NumberOfSeats { get; set; }

        public PassengerCar(string model, 
            int numberOfSeats, 
            Engine engine,
            Chassis chassis,
            Transmission transmission)
                : base(engine, chassis, transmission)
        {
            Model = model;
            NumberOfSeats = numberOfSeats;
        }
    }
}
