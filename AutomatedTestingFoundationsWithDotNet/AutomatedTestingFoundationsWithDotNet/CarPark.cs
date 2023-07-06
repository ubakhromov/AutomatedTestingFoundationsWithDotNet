namespace AutomatedTestingFoundationsWithDotNet
{
    public class CarPark
    {
        private Vehicle[] vehicles;

        public CarPark()
        {
            vehicles = new Vehicle[4];

            vehicles[0] = new PassengerCar("Toyota Camry", 5,
                new Engine(250, 3.5, "Petrol", "12345"),
                new Chassis(4, "ABC123", 500),
                new Transmission("Automatic", 6, "Toyota"));

            vehicles[1] = new Truck("Ford", 1500,
                new Engine(300, 5.0, "Diesel", "67890"),
                new Chassis(8, "DEF456", 2000),
                new Transmission("Manual", 8, "Ford"));

            vehicles[2] = new Bus("Public Transport Inc.", 40,
                new Engine(200, 4.2, "Diesel", "13579"),
                new Chassis(6, "GHI789", 3000),
                new Transmission("Automatic", 6, "Mercedes"));

            vehicles[3] = new Scooter("Vespa", 80,
                new Engine(10, 0.15, "Petrol", "24680"),
                new Chassis(2, "JKL012", 100),
                new Transmission("", 0, ""));
        }

        public void PrintVehicleInformation()
        {
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine("--------------------");
                if (vehicle is PassengerCar passengerCar)
                {
                    Console.WriteLine("Passenger Car:");
                    Console.WriteLine($"Model: {passengerCar.Model}");
                    Console.WriteLine($"Number of Seats: {passengerCar.NumberOfSeats}");
                }
                else if (vehicle is Truck truck)
                {
                    Console.WriteLine("Truck:");
                    Console.WriteLine($"Manufacturer: {truck.Manufacturer}");
                    Console.WriteLine($"Cargo Capacity: {truck.CargoCapacity}");
                }
                else if (vehicle is Bus bus)
                {
                    Console.WriteLine("Bus:");
                    Console.WriteLine($"Operator: {bus.Operator}");
                    Console.WriteLine($"Number of Passengers: {bus.NumberOfPassengers}");
                }
                else if (vehicle is Scooter scooter)
                {
                    Console.WriteLine("Scooter:");
                    Console.WriteLine($"Brand: {scooter.Brand}");
                    Console.WriteLine($"Max Speed: {scooter.MaxSpeed}");
                }

                Console.WriteLine("Engine:");
                Console.WriteLine($"Power: {vehicle.Engine.Power}");
                Console.WriteLine($"Volume: {vehicle.Engine.Volume}");
                Console.WriteLine($"Type: {vehicle.Engine.Type}");
                Console.WriteLine($"Serial Number: {vehicle.Engine.SerialNumber}");

                Console.WriteLine("Chassis:");
                Console.WriteLine($"Wheels Number: {vehicle.Chassis.WheelsNumber}");
                Console.WriteLine($"Number: {vehicle.Chassis.Number}");
                Console.WriteLine($"Permissible Load: {vehicle.Chassis.PermissibleLoad}");

                Console.WriteLine("Transmission:");
                Console.WriteLine($"Type: {vehicle.Transmission.Type}");
                Console.WriteLine($"Number of Gears: {vehicle.Transmission.NumberOfGears}");
                Console.WriteLine($"Manufacturer: {vehicle.Transmission.Manufacturer}");

                Console.WriteLine("--------------------");
            }
        }
    }
}
