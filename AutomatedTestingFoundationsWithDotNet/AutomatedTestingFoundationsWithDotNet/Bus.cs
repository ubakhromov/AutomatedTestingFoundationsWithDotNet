namespace AutomatedTestingFoundationsWithDotNet
{
    public class Bus : Vehicle 
    {
        public string Operator { get; set; }
        public int NumberOfPassengers { get; set; }

        public Bus(string operatorName,
            int numberOfPassengers, 
            Engine engine,
            Chassis chassis,
            Transmission transmission)
                : base(engine, chassis, transmission)
        {
            Operator = operatorName;
            NumberOfPassengers = numberOfPassengers;
        }
    }

}
